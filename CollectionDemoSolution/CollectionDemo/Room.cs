using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{   

    //Composite Class
    //  a composite contains references to other classes
    //  the reference may be a single isntance or within a List<T>
    class Room
    {
        private string _Color;
        public string Name { get; set; }
        public string Color 
        {   
            get { return _Color; }
            set { _Color = string.IsNullOrEmpty(value) ? "White" : value; } 
        }

        public List<Wall> Walls { get; set; }

        public List<Opening> Openings { get; set; }
    }
}
