using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    public class SQLiteDB
    {
        // Three basic SQLite objects:
        public SQLiteConnection sqConnection;
        public SQLiteCommand sqCmd;
        public SQLiteDataReader sqDatareader;

        public string queries;


        public SQLiteDB()
        {
            //no constructor
        }

        //Open and create database name
        public void open()
        {
            string dbsetup;
            string cwd = System.Environment.CurrentDirectory;
            //System.Console.WriteLine(cwd);

            string filename = System.Environment.MachineName + DateTime.Now.ToString("ddMMyyyy") + ".sqlite";
            //string absFilename = "@" + cwd + filename;
            string absFilename = cwd + "\\" +  filename;
            //System.Console.WriteLine(absFilename);

            //System.Console.WriteLine(System.IO.File.Exists(absFilename) ? "File Exists." : "File Does Not Exist");
            bool exist = System.IO.File.Exists(absFilename);

            if (exist == true)
            {
                System.Console.WriteLine("Opening Existing Database: " + filename);
                dbsetup = String.Format("Data Source={0};Version=3;New=False;Compress=True;", filename);
            }
            else
            {
                System.Console.WriteLine("Creating New Database: " + filename);
                dbsetup = String.Format("Data Source={0};Version=3;New=True;Compress=True;", filename);
            }


            System.Console.WriteLine("Opening Database");

            try
            {
                //sqConnection = new SQLiteConnection("Data Source=" + timestamp + ".sqlite;Version=3;New=True;Compress=True;");
                sqConnection = new SQLiteConnection(dbsetup);
                sqConnection.Open();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Console.WriteLine("DB open/creation failed");
            }

            System.Console.WriteLine("DB Open");
        }

        //creates databases based on exact time to ensure only 1 data set will be inside
        public void testingOpen()
        {
            System.Console.WriteLine("Creating short-term testing Database");

            string dbsetup = String.Format("Data Source={0}{1}.sqlite;Version=3;New=True;Compress=True;", System.Environment.MachineName, DateTime.Now.ToString("ddMMyy_HHmmsstt"));

            sqConnection = new SQLiteConnection(dbsetup);
            try
            {
                sqConnection.Open();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                System.Console.WriteLine("DB open/creation failed");
            }

            System.Console.WriteLine("DB Open");


        }


        public void close()
        {
            sqConnection.Close();
        }

        //sets up the SQL tables but first checks if they already exist
        public bool initTables()
        {
            System.Console.WriteLine("Initializing Non-Testing Tables");


            bool exist = tableExists("headerManager");

            if (exist == false)
            {
                try
                {
                    //table for station name/location, the day of creation, and whether its testing/examination/practice mode
                    queries = "CREATE TABLE IF NOT EXISTS headerManager (session INTEGER PRIMARY KEY, user VARCHAR(30), machine VARCHAR(30), timestamp VARCHAR(30), mode VARCHAR(30));";
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    sqCmd.ExecuteNonQuery();

                    //table for session, frame, object and it's x,y,z values, and if it fell in permitable range
                    queries = "CREATE TABLE IF NOT EXISTS frameManager (session INTEGER, frame INTEGER, object VARCHAR(20), accept VARCHAR(20), x DOUBLE, y DOUBLE, z DOUBLE, PRIMARY KEY(session, frame, object));";
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    sqCmd.ExecuteNonQuery();

                    //table for managing the box frame around individual joint points (session, object, min/max x,y,z)
                    queries = "CREATE TABLE IF NOT EXISTS boxManager (session INTEGER, object VARCHAR(20), minx DOUBLE, miny DOUBLE, minz DOUBLE, maxx DOUBLE, maxy DOUBLE, maxz double, PRIMARY KEY (session, object));";
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    sqCmd.ExecuteNonQuery();

                    System.Console.WriteLine("Tables Created return true");
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
                //end table creation try
                return true;
            }
            else
            {
                System.Console.WriteLine("Tables already existed return false");
                return false;
            }
        }

        public bool tableExists(string tablename)
        {
            int exist = 0;
            try//to see if the tables already exist
            {
                //Checks SQLite manager table to see if the table name exists
                queries = String.Format("SELECT count(*) AS int FROM sqlite_master WHERE type='table' AND name='{0}';", tablename);
                sqCmd = new SQLiteCommand(queries, sqConnection);
                exist = (int)Convert.ToInt32(sqCmd.ExecuteScalar());
                //System.Console.WriteLine("Exist value: " + exist);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }
            //return true if exists
            if (exist == 1)
                return true;
            //else return false
            else
                return false;
        }

        public bool tableEmpty(string tablename)
        {
            int exist = 0;

            //if table exists
            if(tableExists(tablename))
            {
                try//to see if there are rows inserted into the table
                {
                    queries = String.Format("SELECT count(*) AS int FROM {0};", tablename);
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    exist = (int)Convert.ToInt32(sqCmd.ExecuteScalar());
                    //System.Console.WriteLine("Rows found: " + exist);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }

            //return true if empty
            if (exist == 0)
                return true;
            //else return false if (empty)
            else
                return false;
        }

        //creates header should be ran with every calibrate, automatically run once if new database
        public void createHeader(string user, string mode)
        {
            System.Console.WriteLine("Creating new header");

            //shared data between existing and non-existing
            string machine = System.Environment.MachineName;
            string time = DateTime.Now.ToString("HH_MM_ss_tt");

            try
            {
                //if table is empty sessionID is 0
                if (tableEmpty("headerManager"))
                {
                    //reference table code
                    //"CREATE TABLE IF NOT EXISTS headerManager (session INTEGER PRIMARY KEY, user VARCHAR(30), machine VARCHAR(30), timestamp VARCHAR(30), mode VARCHAR(30));";
                    queries = "INSERT INTO headerManager (session, user, machine, timestamp, mode) VALUES (@session, @user, @machine, @time, @mode);";
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    //empty table means session 0
                    sqCmd.Parameters.AddWithValue("@session", 0);
                    sqCmd.Parameters.AddWithValue("@user", user);
                    sqCmd.Parameters.AddWithValue("@machine", machine);
                    sqCmd.Parameters.AddWithValue("@time", time);
                    sqCmd.Parameters.AddWithValue("@mode", mode);
                    sqCmd.ExecuteNonQuery();
                }
                //not empty table
                else
                {
                    //get highest sessionID then incriment it
                    int nextSessionID = getLastSessionID() + 1;

                    queries = "INSERT INTO headerManager (session, user, machine, timestamp, mode) VALUES (@session, @user, @machine, @time, @mode);";
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    //nextSessionID was pulled
                    sqCmd.Parameters.AddWithValue("@session", nextSessionID);
                    sqCmd.Parameters.AddWithValue("@user", user);
                    sqCmd.Parameters.AddWithValue("@machine", machine);
                    sqCmd.Parameters.AddWithValue("@time", time);
                    sqCmd.Parameters.AddWithValue("@mode", mode);
                    sqCmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Header Insert End");

        }

        public int getLastSessionID()
        {
            int count;
            //if empty return -1 to get 0 increment
            if (tableEmpty("headerManager"))
                return -1;
            //else get max sessionID from table
            else
            {
                try
                {
                    queries = String.Format("SELECT max(session) AS int FROM headerManager;");
                    sqCmd = new SQLiteCommand(queries, sqConnection);
                    count = (int)Convert.ToInt32(sqCmd.ExecuteScalar());
                    System.Console.WriteLine("Highest session value: " + count);
                    return count;
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e);
                    //forced return this should never happen
                    return -100;
                }
            }
        }

        public void addFrame(kFrame frame)
        {
            //System.Console.WriteLine("New frame");

            try
            {
                //reference table code
                //"CREATE TABLE frameManager (session INTEGER, frame INTEGER, object VARCHAR(20), accept VARCHAR(20), x DOUBLE, y DOUBLE, z DOUBLE, PRIMARY KEY(session, frame, object));";
                queries = "INSERT INTO frameManager (session, frame, object, accept, x, y, z) VALUES (@session, @frame, @object, @accept, @x, @y, @z);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@session", frame.getSession());
                sqCmd.Parameters.AddWithValue("@frame", frame.getFrame());
                sqCmd.Parameters.AddWithValue("@object", frame.getObject());
                sqCmd.Parameters.AddWithValue("@accept", frame.getAccept());
                sqCmd.Parameters.AddWithValue("@x", frame.getX());
                sqCmd.Parameters.AddWithValue("@y", frame.getY());
                sqCmd.Parameters.AddWithValue("@z", frame.getZ());
                sqCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            //System.Console.WriteLine("New frame END");
        }

        public List<kFrame> getSession(int sessionid)
        {
            //gets all frames for a specified sessionId
            System.Console.WriteLine("Get ALL frames for session #" + sessionid);

            //return list of kframes
            List<kFrame> frameValues = new List<kFrame>();

            try
            {
                //create a reader object to read rows
                queries = "SELECT * FROM frameManager WHERE session=@sessionid";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@sessionid", sessionid);
                sqDatareader = sqCmd.ExecuteReader();

                //while a row exists with data
                while(sqDatareader.Read())
                {
                    //int fnum = (int)sqDatareader["frame"];
                    kFrame frame = new kFrame((int)sqDatareader["session"], (int)sqDatareader["frame"], (string)sqDatareader["object"], (string)sqDatareader["accept"], (double)sqDatareader["x"], (double)sqDatareader["y"], (double)sqDatareader["z"]);
                    frameValues.Add(frame);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Sucess. Returning session frames");

            return frameValues;
        }


        public List<kFrame> getSkeleton(int sessionid, int framenum)
        {
            System.Console.WriteLine("Get frame for session #" + sessionid + " and frame #" + framenum);

            //create list of kframes to return
            List<kFrame> frameValues = new List<kFrame>();

            try
            {
                //create reader object to read rows
                queries = "SELECT * FROM frameManager WHERE frame=@frame, and session=@sessionid";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@frame", framenum);
                sqCmd.Parameters.AddWithValue("@sessionid", sessionid);
                sqDatareader = sqCmd.ExecuteReader();

                //read while rows exist with data
                while(sqDatareader.Read())
                {
                    kFrame frame = new kFrame((int)sqDatareader["session"], (int)sqDatareader["frame"], (string)sqDatareader["object"], (string)sqDatareader["accept"], (double)sqDatareader["x"], (double)sqDatareader["y"], (double)sqDatareader["z"]);
                    frameValues.Add(frame);
                }
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Sucess. Returning found skeletal frame");

            return frameValues;
        }

/* pointless function with zero use so far but left in code
        public kFrame getObjkFrame(int framenum, int sessionid, string obj)
        {
            System.Console.WriteLine("Get frame for obj" + obj.ToString());

            kFrame frame = null;

            try
            {
                queries = "SELECT * FROM frameManager WHERE frame=@frame, and session=@sessionid, and object=@object";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@frame", framenum);
                sqCmd.Parameters.AddWithValue("@sessionid", sessionid);
                sqCmd.Parameters.AddWithValue("@object", obj);
                sqDatareader = sqCmd.ExecuteReader();

                sqDatareader.Read();

                frame = new kFrame((int)sqDatareader["session"], (int)sqDatareader["frame"], (string)sqDatareader["object"], (string)sqDatareader["accept"], (double)sqDatareader["x"], (double)sqDatareader["y"], (double)sqDatareader["z"]);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Return found frame");

            return frame;
        }
*/
        //create the frame for acceptable movement, highly recommended to change range multipliers with further testing
        public void createBox(kFrame frame)
        {
            //System.Console.WriteLine("Creating box parameter");

            try
            {
                //reference for table code
                //"CREATE TABLE boxManager (session INTEGER, object VARCHAR(20), minx DOUBLE, miny DOUBLE, minz DOUBLE, maxx DOUBLE, maxy DOUBLE, maxz double, PRIMARY KEY (session, object));";
                queries = "INSERT INTO boxManager (session, object, minx, miny, minz, maxx, maxy, maxz) VALUES (@session, @object, @minx, @miny, @minz, @maxx, @maxy, @maxz);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@session", frame.getSession());
                sqCmd.Parameters.AddWithValue("@object", frame.getObject());
                sqCmd.Parameters.AddWithValue("@minx", frame.getX() * 1 / 4);
                sqCmd.Parameters.AddWithValue("@miny", frame.getY() * 1 / 4);
                sqCmd.Parameters.AddWithValue("@minz", frame.getZ() * 1 / 4);
                sqCmd.Parameters.AddWithValue("@maxx", frame.getX() * 2);
                sqCmd.Parameters.AddWithValue("@maxy", frame.getY() * 2);
                sqCmd.Parameters.AddWithValue("@maxz", frame.getZ() * 2);
                sqCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            //System.Console.WriteLine("Box parameters inserted");

        }

        public void printSession(int sessionid)
        {
            //System.Console.WriteLine("Print Frames");

            try
            {
                List<kFrame> frameValues = new List<kFrame>();
                frameValues = getSession(sessionid);

                foreach(kFrame f in frameValues)
                {
                    System.Console.WriteLine("Frame #" + f.getFrame() + ", Object: " + f.getObject() + ", Accepted: " + f.getAccept() + ", Coordinates(x,y,z): (" + f.getX() + "," + f.getY() + "," + f.getZ(), ")"); 
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            //System.Console.WriteLine("Print END");
        }
    }
}