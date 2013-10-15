using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    public class kFrame
    {
        private int frame, session;
        private double x, y, z;
        private string acceptable;
        private string obj;


        public kFrame(int Session, int newFrame, string Obj, string Accept, double x, double y, double z)
        {
            this.session = Session;
            this.frame = newFrame;
            this.obj = Obj;
            this.acceptable = Accept;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public int getSession()
        {
            return this.session;
        }
        
        public int getFrame()
        {
            return this.frame;
        }

        public string getAccept()
        {
            return this.acceptable;
        }

        public string getObject()
        {
            return this.obj;
        }


        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        public double getZ()
        {
            return this.z;
        }
    }
}