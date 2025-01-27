using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Height=0;
            Width=0;    
        }
        public Rectangle(int width,int height)
        {
            Height = height;
            Width = width;
        }
        public Rectangle(int VALUE)
        {
            Height = VALUE;
            Width = VALUE;
        }
    }
}
