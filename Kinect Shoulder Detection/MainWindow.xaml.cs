namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    using System;
    using System.Data.SQLite;
    using System.Globalization;
    using System.IO;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using Microsoft.Kinect;
    //using Finisar.SQLite;
    //using SQLiteDB;
    //using kFrame;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Width of output drawing
        /// </summary>
        private const float RenderWidth = 640.0f;

        /// <summary>
        /// Height of our output drawing
        /// </summary>
        private const float RenderHeight = 480.0f;

        /// <summary>
        /// Thickness of drawn joint lines
        /// </summary>
        private const double JointThickness = 3;

        /// <summary>
        /// Thickness of body center ellipse
        /// </summary>
        private const double BodyCenterThickness = 10;

        /// <summary>
        /// Thickness of clip edge rectangles
        /// </summary>
        private const double ClipBoundsThickness = 10;

        /// <summary>
        /// Brush used to draw skeleton center point
        /// </summary>
        private readonly Brush centerPointBrush = Brushes.Blue;

        /// <summary>
        /// Brush used for drawing joints that are currently tracked
        /// </summary>
        private readonly Brush trackedJointBrush = new SolidColorBrush(Color.FromArgb(255, 68, 192, 68));

        /// <summary>
        /// Brush used for drawing joints that are currently inferred
        /// </summary>        
        private readonly Brush inferredJointBrush = Brushes.Yellow;

        /// <summary>
        /// Pen used for drawing bones that are Accepted
        /// </summary>
        private readonly Pen trackedBonePen = new Pen(Brushes.Green, 6);

        /// <summary>
        /// Pen used for drawing bones that are Not Accepted
        /// </summary>
        private readonly Pen NotAccepted_BonePen = new Pen(Brushes.Red , 6);

        /// <summary>
        /// Pen used for drawing bones that are currently inferred
        /// </summary>        
        private readonly Pen inferredBonePen = new Pen(Brushes.Gray, 1);

        /// <summary>
        /// Active Kinect sensor
        /// </summary>
        private KinectSensor sensor;

        /// <summary>
        /// Drawing group for skeleton rendering output
        /// </summary>
        private DrawingGroup drawingGroup;

        /// <summary>
        /// Drawing image that we will display
        /// </summary>
        private DrawingImage imageSource;


        // Saved Skeletal Frame
        SkeletonFrame currentSkeletonFrame = null;
        Skeleton[] Accepted_Skeletons = new Skeleton[0];

        // Saved shoulder data points
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderCenter_Lower;
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderLeft_Lower;
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderRight_Lower;
        //lower bounds
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderCenter_Upper;
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderLeft_Upper;
        public Microsoft.Kinect.SkeletonPoint Accepted_ShoulderRight_Upper;
        //upper bounds
        //
        bool accept = true;
        // are we inside our box?
        bool calibrated = false;
        // have we calibrated?
        int sessionID = 0;
        //Database Session
        SQLiteDB sessionData;
        //Database
        int frame_counter = 0;


        /// <summary>
        /// Testing values to prove accuracy and precision
        /// </summary>
        /// 

        bool Minimum_Testing = false; // set to print data
        bool Maximum_Testing = false;  // set to print data
        bool z_testing = false; // set to print data
        bool x_testing = false; // set to print data

        public Microsoft.Kinect.SkeletonPoint Minimum_Left; // storage of minimum values (x,y,z) for testing
        public Microsoft.Kinect.SkeletonPoint Maximum_Left; // storage of maximum values (x,y,z) for testing

        /// <summary>
        /// End of testing variables
        /// </summary>

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws indicators to show which edges are clipping skeleton data
        /// </summary>
        /// <param name="skeleton">skeleton to draw clipping information for</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        private static void RenderClippedEdges(Skeleton skeleton, DrawingContext drawingContext)
        {
            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Bottom))
            {
                drawingContext.DrawRectangle(
                    Brushes.Red,
                    null,
                    new Rect(0, RenderHeight - ClipBoundsThickness, RenderWidth, ClipBoundsThickness));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Top))
            {
                drawingContext.DrawRectangle(
                    Brushes.Red,
                    null,
                    new Rect(0, 0, RenderWidth, ClipBoundsThickness));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Left))
            {
                drawingContext.DrawRectangle(
                    Brushes.Red,
                    null,
                    new Rect(0, 0, ClipBoundsThickness, RenderHeight));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Right))
            {
                drawingContext.DrawRectangle(
                    Brushes.Red,
                    null,
                    new Rect(RenderWidth - ClipBoundsThickness, 0, ClipBoundsThickness, RenderHeight));
            }
        }

        /// <summary>
        /// Execute startup tasks
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("Creating DB Session");

            sessionData = new SQLiteDB();
            sessionData.open();

            System.Console.WriteLine("Running Table Creation");
            sessionData.initTables();

            System.Console.WriteLine("Running Header Creation");
            sessionData.createHeader("Alex", "testing");

            sessionID = sessionData.getLastSessionID();
            // Create the drawing group we'll use for drawing
            this.drawingGroup = new DrawingGroup();

            // Create an image source that we can use in our image control
            this.imageSource = new DrawingImage(this.drawingGroup);

            // Display the drawing using our image control
            Image.Source = this.imageSource;

            //Initialize the minimum value to a large value FOR TESTING
            Minimum_Left.X = -100;
            Minimum_Left.Y = 100;
            Minimum_Left.Z = 100;
            //Initialize the maximum value to a small value FOR TESTING
            Maximum_Left.X = 0;
            Maximum_Left.Y = 0;
            Maximum_Left.Z = 0;

            // Look through all sensors and start the first connected one.
            // This requires that a Kinect is connected at the time of app startup.
            // To make your app robust against plug/unplug, 
            // it is recommended to use KinectSensorChooser provided in Microsoft.Kinect.Toolkit (See components in Toolkit Browser).
            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                {
                    this.sensor = potentialSensor;
                    break;
                }
            }

            if (null != this.sensor)
            {
                // Turn on the skeleton stream to receive skeleton frames
                this.sensor.SkeletonStream.Enable();

                EnableNearModeSkeletalTracking(); // Enable Near Mode!

                // Add an event handler to be called whenever there is new color frame data
                this.sensor.SkeletonFrameReady += this.SensorSkeletonFrameReady;

                // Start the sensor!
                try
                {
                    this.sensor.Start();
                }
                catch (IOException)
                {
                    this.sensor = null;
                }
            }

            if (null == this.sensor)
            {
                this.statusBarText.Text = Properties.Resources.NoKinectReady;
            }
        }

        // Code for enabling near mode so we can be at < .4m

        private void EnableNearModeSkeletalTracking()
        {
            if (this.sensor != null && this.sensor.DepthStream != null && this.sensor.SkeletonStream != null)
            {
                this.sensor.DepthStream.Range = DepthRange.Near; // Depth in near range enabled
                this.sensor.SkeletonStream.EnableTrackingInNearRange = true; // enable returning skeletons while depth is in Near Range
                this.sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated; // Use seated tracking
                //this.sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default; // Use Standing Mode
            }
        }

        /// <summary>
        /// Execute shutdown tasks
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (null != this.sensor)
            {
                this.sensor.Stop();
            }
        }

        private bool IS_ACCEPTED(Skeleton[] skeleton)
        {
            bool b = true;

            foreach (Skeleton skel in skeleton)
            {

                JointCollection jointCollection = skel.Joints;

                if (jointCollection[JointType.ShoulderCenter].Position.X != 0)
                {

                    // X COORDS
                    if (jointCollection[JointType.ShoulderLeft].Position.X > Accepted_ShoulderLeft_Lower.X || jointCollection[JointType.ShoulderLeft].Position.X < Accepted_ShoulderLeft_Upper.X)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Left X");
                        //System.Console.WriteLine(Accepted_ShoulderLeft_Lower.X);
                        //System.Console.WriteLine(jointCollection[JointType.ShoulderLeft].Position.X);
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderRight].Position.X < Accepted_ShoulderRight_Lower.X || jointCollection[JointType.ShoulderRight].Position.X > Accepted_ShoulderRight_Upper.X)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Right X");
                        //draw a red line on the left shoulder and set flags
                    }
                        /*
                         * Completeness Tests
                         * 
                         * Ignoring the use of shoulder centers x coordinates for testing for the time being.
                         * Center coordinates inability to conform to a standard of positive or negative is too time consuming.
                         * 
                    else if (jointCollection[JointType.ShoulderCenter].Position.X < 0)
                    {
                        if(jointCollection[JointType.ShoulderCenter].Position.X > Accepted_ShoulderCenter_Lower.X || jointCollection[JointType.ShoulderCenter].Position.X < Accepted_ShoulderCenter_Upper.X)
                        {
                            b = false;
                        }
                        //System.Console.WriteLine("BAD Location Torso X");
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderCenter].Position.X >= 0)
                    {
                        if (jointCollection[JointType.ShoulderCenter].Position.X < Accepted_ShoulderCenter_Lower.X || jointCollection[JointType.ShoulderCenter].Position.X > Accepted_ShoulderCenter_Upper.X)
                        {
                            b = false;
                        }
                    } */

                    // Y COORDS
                    if (jointCollection[JointType.ShoulderLeft].Position.Y < Accepted_ShoulderLeft_Lower.Y || jointCollection[JointType.ShoulderLeft].Position.Y > Accepted_ShoulderLeft_Upper.Y)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Left Y");
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderRight].Position.Y < Accepted_ShoulderRight_Lower.Y || jointCollection[JointType.ShoulderRight].Position.Y > Accepted_ShoulderRight_Upper.Y)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Right Y");
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderCenter].Position.Y < Accepted_ShoulderCenter_Lower.Y || jointCollection[JointType.ShoulderCenter].Position.Y > Accepted_ShoulderCenter_Upper.Y)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Torso Y");
                        //draw a red line on the left shoulder and set flags
                    }

                    //Z COORDS
                    if (jointCollection[JointType.ShoulderLeft].Position.Z < Accepted_ShoulderLeft_Lower.Z || jointCollection[JointType.ShoulderLeft].Position.Z > Accepted_ShoulderLeft_Upper.Z)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Left Z");
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderRight].Position.Z < Accepted_ShoulderRight_Lower.Z || jointCollection[JointType.ShoulderRight].Position.Z > Accepted_ShoulderRight_Upper.Z)
                    {
                        b = false;
                        //System.Console.WriteLine("BAD Location Right Z");
                        //draw a red line on the left shoulder and set flags
                    }
                    else if (jointCollection[JointType.ShoulderCenter].Position.Z < Accepted_ShoulderCenter_Lower.Z || jointCollection[JointType.ShoulderCenter].Position.Z > Accepted_ShoulderCenter_Upper.Z)
                    {
                        b = false;
                        //draw a red line on the left shoulder and set flags
                        //System.Console.WriteLine("BAD Location Torso Z");
                    }  
                }
            }
            return b;
        }

        /// <summary>
        /// Event handler for Kinect sensor's SkeletonFrameReady event
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {

            Skeleton[] skeletons = new Skeleton[0];

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    //Keep current frame at a global
                    currentSkeletonFrame = skeletonFrame;

                    Accepted_Skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                    skeletonFrame.CopySkeletonDataTo(Accepted_Skeletons);
                    
                    // Insert Points into Database

                    // 
                    //
                    //CALCULATE IF IN ACCEPTED RANGE
                    if (calibrated)
                    {
                        accept = IS_ACCEPTED(skeletons);
                        //END CALCULATIONS
                        foreach (Skeleton skel in Accepted_Skeletons)
                        {
                            JointCollection jointCollection = skel.Joints;

                            //Center Lower Bound
                            if (jointCollection[JointType.ShoulderCenter].Position.X != 0)
                            {
                                // sets the y point to the newest skeletons y if it is of a lesser value and prints it
                                if (Minimum_Testing && Minimum_Left.Y > jointCollection[JointType.ShoulderLeft].Position.Y)
                                {
                                    Minimum_Left.Y = jointCollection[JointType.ShoulderLeft].Position.Y;
                                    System.Console.WriteLine(Minimum_Left.Y);
                                }
                                // set the y point to the newest skeletons y if it is of a greater value and prints it
                                if (Maximum_Testing && Maximum_Left.Y < jointCollection[JointType.ShoulderLeft].Position.Y)
                                {
                                    Maximum_Left.Y = jointCollection[JointType.ShoulderLeft].Position.Y;
                                    System.Console.WriteLine(Maximum_Left.Y);
                                }
                                // testing on z's
                                if (z_testing)
                                {
                                    // sets the z point to the newest skeletons z if it is of a lesser value
                                    if (Minimum_Left.Z > jointCollection[JointType.ShoulderLeft].Position.Z)
                                    {
                                        Minimum_Left.Z = jointCollection[JointType.ShoulderLeft].Position.Z;
                                    }
                                    // sets the z point to the newest skeletons z if it is of a greater value
                                    if (Maximum_Left.Z < jointCollection[JointType.ShoulderLeft].Position.Z)
                                    {
                                        Maximum_Left.Z = jointCollection[JointType.ShoulderLeft].Position.Z;
                                    }
                                    System.Console.WriteLine(Minimum_Left.Z);
                                    System.Console.WriteLine(Maximum_Left.Z);
                                    System.Console.WriteLine("Tests");
                                }
                                // testing on x's
                                if (x_testing)
                                {
                                    // sets the x point to the newest skeletons z if it is of a lesser value
                                    if (Minimum_Left.X < jointCollection[JointType.ShoulderLeft].Position.X)
                                    {
                                        Minimum_Left.X = jointCollection[JointType.ShoulderLeft].Position.X;
                                    }
                                    // sets the x point to the newest skeletons z if it is of a greater value
                                    if (Maximum_Left.X > jointCollection[JointType.ShoulderLeft].Position.X)
                                    {
                                        Maximum_Left.X = jointCollection[JointType.ShoulderLeft].Position.X;
                                    }
                                    System.Console.WriteLine(Minimum_Left.X);
                                    System.Console.WriteLine(Maximum_Left.X);
                                    System.Console.WriteLine("Tests");
                                }
                                if (accept)
                                {
                                    string str = "Is Accepted";
                                    //Insert "Is Accepted" into Database
                                    InsertDB_Collected("LEFT SHOULDER", str, jointCollection[JointType.ShoulderLeft].Position.X, jointCollection[JointType.ShoulderLeft].Position.Y, jointCollection[JointType.ShoulderLeft].Position.Z);
                                    InsertDB_Collected("RIGHT SHOULDER", str, jointCollection[JointType.ShoulderRight].Position.X, jointCollection[JointType.ShoulderRight].Position.Y, jointCollection[JointType.ShoulderRight].Position.Z);
                                    InsertDB_Collected("TORSO", str, jointCollection[JointType.ShoulderCenter].Position.X, jointCollection[JointType.ShoulderCenter].Position.Y, jointCollection[JointType.ShoulderCenter].Position.Z);
                                    // elbows for testing purposes
                                    //InsertDB_Collected("RIGHT ELBOW", str, jointCollection[JointType.ElbowRight].Position.X, jointCollection[JointType.ElbowRight].Position.Y, jointCollection[JointType.ElbowRight].Position.Z);
                                    //InsertDB_Collected("LEFT ELBOW", str, jointCollection[JointType.ElbowLeft].Position.X, jointCollection[JointType.ElbowLeft].Position.Y, jointCollection[JointType.ElbowLeft].Position.Z);
                                }
                                else
                                {
                                    string str = "Is Not Accepted";
                                    //Insert "Is Not Accepted" into Database
                                    InsertDB_Collected("LEFT SHOULDER", str, jointCollection[JointType.ShoulderLeft].Position.X, jointCollection[JointType.ShoulderLeft].Position.Y, jointCollection[JointType.ShoulderLeft].Position.Z);
                                    InsertDB_Collected("RIGHT SHOULDER", str, jointCollection[JointType.ShoulderRight].Position.X, jointCollection[JointType.ShoulderRight].Position.Y, jointCollection[JointType.ShoulderRight].Position.Z);
                                    InsertDB_Collected("TORSO", str, jointCollection[JointType.ShoulderCenter].Position.X, jointCollection[JointType.ShoulderCenter].Position.Y, jointCollection[JointType.ShoulderCenter].Position.Z);
                                    // elbows for testing purposes
                                    //InsertDB_Collected("RIGHT ELBOW", str, jointCollection[JointType.ElbowRight].Position.X, jointCollection[JointType.ElbowRight].Position.Y, jointCollection[JointType.ElbowRight].Position.Z);
                                    //InsertDB_Collected("LEFT ELBOW", str, jointCollection[JointType.ElbowLeft].Position.X, jointCollection[JointType.ElbowLeft].Position.Y, jointCollection[JointType.ElbowLeft].Position.Z);
                                }
                            }
                        }
                        frame_counter++;
                    }
                }
            }

            using (DrawingContext dc = this.drawingGroup.Open())
            {
                // Draw a transparent background to set the render size
                dc.DrawRectangle(Brushes.Black, null, new Rect(0.0, 0.0, RenderWidth, RenderHeight));

                if (skeletons.Length != 0)
                {
                    foreach (Skeleton skel in skeletons)
                    {
                        RenderClippedEdges(skel, dc);

                        if (skel.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            this.DrawBonesAndJoints(skel, dc);
                        }
                        else if (skel.TrackingState == SkeletonTrackingState.PositionOnly)
                        {
                            dc.DrawEllipse(
                            this.centerPointBrush,
                            null,
                            this.SkeletonPointToScreen(skel.Position),
                            BodyCenterThickness,
                            BodyCenterThickness);
                        }
                    }
                }

                // prevent drawing outside of our render area
                this.drawingGroup.ClipGeometry = new RectangleGeometry(new Rect(0.0, 0.0, RenderWidth, RenderHeight));
            }
        }



        /// <summary>
        /// Draws a skeleton's bones and joints
        /// </summary>
        /// <param name="skeleton">skeleton to draw</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        private void DrawBonesAndJoints(Skeleton skeleton, DrawingContext drawingContext)
        {
            // Render Torso
            this.DrawBone(skeleton, drawingContext, JointType.Head, JointType.ShoulderCenter);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderRight);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.Spine);
            this.DrawBone(skeleton, drawingContext, JointType.Spine, JointType.HipCenter);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipLeft);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipRight);

            // Left Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderLeft, JointType.ElbowLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowLeft, JointType.WristLeft);
            this.DrawBone(skeleton, drawingContext, JointType.WristLeft, JointType.HandLeft);

            // Right Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderRight, JointType.ElbowRight);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowRight, JointType.WristRight);
            this.DrawBone(skeleton, drawingContext, JointType.WristRight, JointType.HandRight);

            // Left Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipLeft, JointType.KneeLeft);
            this.DrawBone(skeleton, drawingContext, JointType.KneeLeft, JointType.AnkleLeft);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleLeft, JointType.FootLeft);

            // Right Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipRight, JointType.KneeRight);
            this.DrawBone(skeleton, drawingContext, JointType.KneeRight, JointType.AnkleRight);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleRight, JointType.FootRight);

            // Render Joints
            foreach (Joint joint in skeleton.Joints)
            {
                Brush drawBrush = null;

                if (joint.TrackingState == JointTrackingState.Tracked)
                {
                    if (accept)
                    {
                        drawBrush = this.trackedJointBrush;
                    }
                    else
                    {
                        drawBrush = Brushes.Red;
                    }
                }
                else if (joint.TrackingState == JointTrackingState.Inferred)
                {
                    drawBrush = this.inferredJointBrush;
                }

                if (drawBrush != null)
                {
                    drawingContext.DrawEllipse(drawBrush, null, this.SkeletonPointToScreen(joint.Position), JointThickness, JointThickness);
                }
            }
        }

        /// <summary>
        /// Maps a SkeletonPoint to lie within our render space and converts to Point
        /// </summary>
        /// <param name="skelpoint">point to map</param>
        /// <returns>mapped point</returns>
        private Point SkeletonPointToScreen(SkeletonPoint skelpoint)
        {
            // Convert point to depth space.  
            // We are not using depth directly, but we do want the points in our 640x480 output resolution.
            DepthImagePoint depthPoint = this.sensor.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);
            return new Point(depthPoint.X, depthPoint.Y);
        }

        /// <summary>
        /// Draws a bone line between two joints
        /// </summary>
        /// <param name="skeleton">skeleton to draw bones from</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        /// <param name="jointType0">joint to start drawing from</param>
        /// <param name="jointType1">joint to end drawing at</param>
        private void DrawBone(Skeleton skeleton, DrawingContext drawingContext, JointType jointType0, JointType jointType1)
        {
            Joint joint0 = skeleton.Joints[jointType0];
            Joint joint1 = skeleton.Joints[jointType1];

            // If we can't find either of these joints, exit
            if (joint0.TrackingState == JointTrackingState.NotTracked ||
                joint1.TrackingState == JointTrackingState.NotTracked)
            {
                return;
            }

            // Don't draw if both points are inferred
            if (joint0.TrackingState == JointTrackingState.Inferred &&
                joint1.TrackingState == JointTrackingState.Inferred)
            {
                return;
            }

            // We assume all drawn bones are inferred unless BOTH joints are tracked
            Pen drawPen = this.inferredBonePen;
            if (joint0.TrackingState == JointTrackingState.Tracked && joint1.TrackingState == JointTrackingState.Tracked)
            {
                if (accept)
                {
                    drawPen = this.trackedBonePen;
                }
                else
                {
                    drawPen = this.NotAccepted_BonePen;
                }
            }

            drawingContext.DrawLine(drawPen, this.SkeletonPointToScreen(joint0.Position), this.SkeletonPointToScreen(joint1.Position));
        }

        private void InsertDB_Collected(string str, string is_accept, float x, float y, float z)
        {
            //System.Console.WriteLine("Inserting Collected Values for " + str);

            kFrame frame = new kFrame(sessionID, frame_counter, str, is_accept, x, y, z);
            sessionData.addFrame(frame);

            //System.Console.WriteLine("Collected Data Inserted");
            //sessionData.printFrames(sessionID);

        }

        private void InsertDB_Calibrate(string str, float x, float y, float z)
        {
            System.Console.WriteLine("Inserting Calibration Values for " + str);

            kFrame boxframe = new kFrame(sessionID, 0, str, null, x, y, z);
            sessionData.createBox(boxframe);

            System.Console.WriteLine("Calibration Data Inserted");
            //sessionData.printFrames(sessionID);
        }

        private void CalibrateMode(object sender, RoutedEventArgs e)
        {
            sessionData.createHeader("User", "Calibrating");
            sessionID = sessionData.getLastSessionID() + 1;

            frame_counter = 0;
            calibrated = true;

            System.Console.WriteLine("Calibrating position");

            if (null != this.sensor)
            {
                // Use the Accepted Skeleton from the last frame to calibrate from
                foreach (Skeleton skel in Accepted_Skeletons)
                {
                    JointCollection jointCollection = skel.Joints;

                    //Center Lower Bound
                    if (jointCollection[JointType.ShoulderCenter].Position.X != 0)
                    {
                        Accepted_ShoulderCenter_Lower.X = (jointCollection[JointType.ShoulderCenter].Position.X * 1 / 4);
                        Accepted_ShoulderCenter_Lower.Y = jointCollection[JointType.ShoulderCenter].Position.Y * 1 / 4;
                        Accepted_ShoulderCenter_Lower.Z = jointCollection[JointType.ShoulderCenter].Position.Z * 1 / 4;
                        //System.Console.WriteLine(Accepted_ShoulderCenter_Lower.Z);
                        //Center Upper Bound
                        Accepted_ShoulderCenter_Upper.X = (jointCollection[JointType.ShoulderCenter].Position.X * 2);
                        Accepted_ShoulderCenter_Upper.Y = jointCollection[JointType.ShoulderCenter].Position.Y * 2;
                        Accepted_ShoulderCenter_Upper.Z = jointCollection[JointType.ShoulderCenter].Position.Z * 2;
                        //Left Lower Bound
                        //System.Console.WriteLine(jointCollection[JointType.ShoulderLeft].Position.X);
                        Accepted_ShoulderLeft_Lower.X = jointCollection[JointType.ShoulderLeft].Position.X * 1 / 4;
                        Accepted_ShoulderLeft_Lower.Y = jointCollection[JointType.ShoulderLeft].Position.Y * 1 / 4;
                        Accepted_ShoulderLeft_Lower.Z = jointCollection[JointType.ShoulderLeft].Position.Z * 1 / 4;
                        //Left Upper Bound
                        Accepted_ShoulderLeft_Upper.X = jointCollection[JointType.ShoulderLeft].Position.X * 2;
                        Accepted_ShoulderLeft_Upper.Y = jointCollection[JointType.ShoulderLeft].Position.Y * 2;
                        Accepted_ShoulderLeft_Upper.Z = jointCollection[JointType.ShoulderLeft].Position.Z * 2;
                        //Right Lower Bound
                        //System.Console.WriteLine(jointCollection[JointType.ShoulderRight].Position.X);
                        Accepted_ShoulderRight_Lower.X = jointCollection[JointType.ShoulderRight].Position.X * 1 / 4;
                        Accepted_ShoulderRight_Lower.Y = jointCollection[JointType.ShoulderRight].Position.Y * 1 / 4;
                        Accepted_ShoulderRight_Lower.Z = jointCollection[JointType.ShoulderRight].Position.Z * 1 / 4;
                        //Right Upper Bound
                        Accepted_ShoulderRight_Upper.X = jointCollection[JointType.ShoulderRight].Position.X * 2;
                        Accepted_ShoulderRight_Upper.Y = jointCollection[JointType.ShoulderRight].Position.Y * 2;
                        Accepted_ShoulderRight_Upper.Z = jointCollection[JointType.ShoulderRight].Position.Z * 2;

                        // Insert Them Into DataBase
                        InsertDB_Calibrate("LEFT SHOULDER", jointCollection[JointType.ShoulderLeft].Position.X, jointCollection[JointType.ShoulderLeft].Position.Y, jointCollection[JointType.ShoulderLeft].Position.Z);
                        InsertDB_Calibrate("RIGHT SHOULDER", jointCollection[JointType.ShoulderRight].Position.X, jointCollection[JointType.ShoulderRight].Position.Y, jointCollection[JointType.ShoulderRight].Position.Z);
                        InsertDB_Calibrate("TORSO", jointCollection[JointType.ShoulderCenter].Position.X, jointCollection[JointType.ShoulderCenter].Position.Y, jointCollection[JointType.ShoulderCenter].Position.Z);
                        //
                    }
                }
            }

            System.Console.WriteLine("Calibrating complete");
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            calibrated = false;
            accept = true;

            // reset testing values
            Minimum_Left.X = -100;
            Minimum_Left.Y = 100;
            Minimum_Left.Z = 100;
            Maximum_Left.Y = 0;
            Maximum_Left.Z = 0;
            Maximum_Left.X = 0;
        }
    }
}