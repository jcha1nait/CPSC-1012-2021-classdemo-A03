using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class Wall
    {
        //private members
        private double _Width;
        private double _Height;

        //properties
        public double Width
        {
            //accessor
            get { return _Width; }
            //mutator
            set { _Width = value > 0 ? value : throw new Exception("Width is invalid"); }
        }

        public double Height
        {
            get { return _Height; }
            set { _Height = value > 0 ? value : throw new Exception("Height is invalid"); }
        }

        //constructor
        //default
        public Wall()
        {
            Width = 10.0;
            Height = 8.0;
        }

        //greedy
        public Wall(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //behaviour (aka method)
        public double WallArea()
        {
            //note no parameters were set up
            //WHY?
            //the method can access the data within the instance
            //  by using either the properties or the private data members
            //GOOD RULE OF THUMB: properties over data members
            return Width * Height;
        }
    }
}
