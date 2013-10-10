using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
//using Finisar.SQLite;
//using Microsoft.Samples.Kinect.ColorBasics.kFrame;
//using System.Windows.Forms;

namespace Microsoft.Samples.Kinect.ColorBasics
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
            //this.onCreate();
        }

        //Open and create database name
        public void open()
        {
            System.Console.WriteLine("Opening Database");

            //original reference "Data Source=test.db;Version=3;New=True;Compress=True;"
            // code to log in (does nothing locally)Uid = admin; Pwd = admin;
            string dbsetup = String.Format("Data Source={0}{1}.db;Version=3;New=True;Compress=True;", System.Environment.MachineName, DateTime.Now.ToString("ddMMyy_HHmmtt"));
            //dbName = String.Format("Data Source=" + DateTime.Now.ToString("ddMMyyyy_HHMMtt") + ".db;Version=3;New=True;Compress=True;"; 

            sqConnection = new SQLiteConnection(dbsetup);
            try
            {
                //sqConnection = new SQLiteConnection("Data Source=" + timestamp + ".sqlite;Version=3;New=True;Compress=True;");
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

        public void initTables()
        {
            System.Console.WriteLine("Initializing Tables");

            try
            {
                //table created when dll starts to keep track of unique identifiers for the program
                queries = "CREATE TABLE headerManager (machine VARCHAR(30) PRIMARY KEY, timestamp VARCHAR(30), mode INTEGER);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.ExecuteNonQuery();

                //table for running time, x,y,z values, and permittable variance values
                queries = "CREATE TABLE frameManager (session INTEGER, frame INTEGER, shoulder VARCHAR(1), accept VARCHAR(1), tx DOUBLE, ty DOUBLE, tz DOUBLE, sx DOUBLE, sy DOUBLE, sz DOUBLE, PRIMARY KEY(session, frame));";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.ExecuteNonQuery();

                queries = "CREATE TABLE boxManager (session INTEGER, part VARCHAR(10), minx DOUBLE, miny DOUBLE, minz DOUBLE, maxx DOUBLE, maxy DOUBLE, maxz double, PRIMARY KEY (session, part));";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.ExecuteNonQuery();

                System.Console.WriteLine("Tables Created");

                //Put header into database

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

        }

        public void createHeader(int Mode)
        {
            System.Console.WriteLine("Creating new header");

            try
            {
                //Put header into database
                string machine = System.Environment.MachineName;
                string time = DateTime.Now.ToString("HH_MM_tt");
                //mode is given in function

                //queries = "INSERT INTO sessionManager (user, timestamp, sessionType) VALUES ('" + machine + "', '" + date + "', 1);";
                queries = "INSERT INTO headerManager (machine, timestamp, mode) VALUES (@machine, @time, @mode);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@machine", machine);
                sqCmd.Parameters.AddWithValue("@time", time);
                sqCmd.Parameters.AddWithValue("@mode", Mode);
                sqCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Header Insert End");

        }

        public void addFrame(kFrame frame, int sessionNum)
        {
            System.Console.WriteLine("New frame");

            try
            {
                //queries = "INSERT INTO frameManager (frame, x, y, z, variance) VALUES (" + frame.getFrame() + ", " + frame.getX() + ", " + frame.getY() + ", " + frame.getZ() + ", " + frame.getVariance() + ");";
                queries = "INSERT INTO frameManager (session, frame, shoulder, accept, tx, ty, tz, sx, sy, sz) VALUES (@session, @frame, @shoulder, @accept, @tx, @ty, @tz, @sx, @sy, @sz);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@session", sessionNum);
                sqCmd.Parameters.AddWithValue("@frame", frame.getFrame());
                sqCmd.Parameters.AddWithValue("@shoulder", frame.getShoulder());
                sqCmd.Parameters.AddWithValue("@accept", frame.getAccept());
                sqCmd.Parameters.AddWithValue("@tx", frame.getTX());
                sqCmd.Parameters.AddWithValue("@ty", frame.getTY());
                sqCmd.Parameters.AddWithValue("@tz", frame.getTZ());
                sqCmd.Parameters.AddWithValue("@sx", frame.getSX());
                sqCmd.Parameters.AddWithValue("@sy", frame.getSY());
                sqCmd.Parameters.AddWithValue("@sz", frame.getSZ());
                sqCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("New frame END");
        }

        public List<kFrame> getAllkFrame(int sessionid)
        {
            System.Console.WriteLine("Get ALL frames");

            List<kFrame> frameValues = new List<kFrame>();

            try
            {
                queries = "SELECT * FROM frameManager WHERE session=@sessionid";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@sessionid", sessionid);
                sqDatareader = sqCmd.ExecuteReader();

                while(sqDatareader.Read())
                {
                    //int fnum = (int)sqDatareader["frame"];
                    kFrame frame = new kFrame((int)sqDatareader["session"], (int)sqDatareader["frame"], (string)sqDatareader["shoulder"], (string)sqDatareader["accept"], (double)sqDatareader["tx"], (double)sqDatareader["ty"], (double)sqDatareader["tz"], (double)sqDatareader["sx"], (double)sqDatareader["sy"], (double)sqDatareader["sz"]);
                    frameValues.Add(frame);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Returning ALL frames");

            return frameValues;
        }


        public kFrame getkFrame(int framenum, int sessionid)
        {
            System.Console.WriteLine("Get frame");

            kFrame frame = null;

            try
            {
                queries = "SELECT * FROM frameManager WHERE frame=@frame, and session=@sessionid";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@frame", framenum);
                sqCmd.Parameters.AddWithValue("@sessionid", sessionid);
                sqDatareader = sqCmd.ExecuteReader();

                sqDatareader.Read();

                frame = new kFrame((int)sqDatareader["session"], (int)sqDatareader["frame"], (string)sqDatareader["shoulder"], (string)sqDatareader["accept"], (double)sqDatareader["tx"], (double)sqDatareader["ty"], (double)sqDatareader["tz"], (double)sqDatareader["sx"], (double)sqDatareader["sy"], (double)sqDatareader["sz"]);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Return found frame");

            return frame;
        }

        public void createBoxes(kFrame frame)
        {
            System.Console.WriteLine("New frame");

            try
            {
                //insert 1 part at a time so the SQL doesn't look awful
                //Shoulder First
                queries = "INSERT INTO boxManager (session, part, minx, miny, minz, maxx, maxy, maxz) VALUES (@session, @part, @minx, @miny, @minz, @maxx, @maxy, @maxz);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@session", frame.getSession());
                sqCmd.Parameters.AddWithValue("@part", "Shoulder");
                sqCmd.Parameters.AddWithValue("@minx", frame.getSX() * .75);
                sqCmd.Parameters.AddWithValue("@miny", frame.getSY() * .75);
                sqCmd.Parameters.AddWithValue("@minz", frame.getSZ() * .75);
                sqCmd.Parameters.AddWithValue("@maxx", frame.getSX() * 1.25);
                sqCmd.Parameters.AddWithValue("@maxy", frame.getSY() * 1.25);
                sqCmd.Parameters.AddWithValue("@maxz", frame.getSZ() * 1.25);
                sqCmd.ExecuteNonQuery();

                //Torso Second
                queries = "INSERT INTO boxManager (session, part, minx, miny, minz, maxx, maxy, maxz) VALUES (@session, @part, @minx, @miny, @minz, @maxx, @maxy, @maxz);";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqCmd.Parameters.AddWithValue("@session", frame.getSession());
                sqCmd.Parameters.AddWithValue("@part", "Torso");
                sqCmd.Parameters.AddWithValue("@minx", frame.getTX() * .75);
                sqCmd.Parameters.AddWithValue("@miny", frame.getTY() * .75);
                sqCmd.Parameters.AddWithValue("@minz", frame.getTZ() * .75);
                sqCmd.Parameters.AddWithValue("@maxx", frame.getTX() * 1.25);
                sqCmd.Parameters.AddWithValue("@maxy", frame.getTY() * 1.25);
                sqCmd.Parameters.AddWithValue("@maxz", frame.getTZ() * 1.25);
                sqCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("New frame END");

        }

        public void printFrames(int sessionid)
        {
            System.Console.WriteLine("Print Frames");

            try
            {
                queries = "SELECT * from frameManager";
                sqCmd = new SQLiteCommand(queries, sqConnection);
                sqDatareader = sqCmd.ExecuteReader();

                while (sqDatareader.Read())
                {
                    System.Console.WriteLine("Frame #" + sqDatareader["frame"] + ": Shoulder: " + sqDatareader["shoulder"] + ", Acceptable Range: " + sqDatareader["accept"] + ", SessionID: " + sqDatareader["session"] + ", two random vals: " + sqDatareader["tx"] + " " + sqDatareader["sz"]);
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            System.Console.WriteLine("Print END");
        }
    }
}