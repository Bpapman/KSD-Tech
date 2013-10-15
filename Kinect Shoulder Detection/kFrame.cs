using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    public class kFrame
    {
        private int frame, session;
        private double tx, ty, tz, sx, sy, sz;
        private string acceptable;
        private string shoulder;


        public kFrame(int Session, int newFrame, string Shoulder, string Accept, double tx, double ty, double tz, double sx, double sy, double sz)
        {
            this.session = Session;
            this.frame = newFrame;
            this.shoulder = Shoulder;
            this.acceptable = Accept;
            this.sx = sx;
            this.sy = sy;
            this.sz = sz;
            this.tx = tx;
            this.ty = ty;
            this.tz = tz;
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

        public string getShoulder()
        {
            return this.shoulder;
        }


        public double getSX()
        {
            return this.sx;
        }

        public double getSY()
        {
            return this.sy;
        }

        public double getSZ()
        {
            return this.sz;
        }

        public double getTX()
        {
            return this.tx;
        }

        public double getTY()
        {
            return this.ty;
        }

        public double getTZ()
        {
            return this.tz;
        }
    }
}