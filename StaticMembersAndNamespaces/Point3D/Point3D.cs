﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D starttingPoint=new Point3D(0,0,0);

        public Point3D(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            string output = "{" + this.x + ", " + this.y + ", " + this.z + "}";
            return output;
        }


        public Point3D StarttingPoint
        {
            get
            {
                return starttingPoint;
            }
        }
    }
}
