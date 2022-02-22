using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class RGB
    {
        public float r;
        public float g;
        public float b;

        public RGB(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public int toColor()
        {
            int ir = (int)(r * 255.0f);
            int ig = (int)(g * 255.0f);
            int ib = (int)(g * 255.0f);
            int ia = 255;
            return (ia << 24) | (ir << 16) | (ig << 8) | (ib << 0);
        }
    }
}
