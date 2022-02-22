using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Interpolation
    {
        public static float lerp(float x, float x0, float x1)
        {
            return x0 + (x1 - x0) * x;
        }

        public static float unlerp(float x, float x0, float x1)
        {
            return (x - x0) / (x1 - x0);
        }

        public static float map(float x, float x0, float x1, float y0, float y1)
        {
            float t = unlerp(x, x0, x1);
            return lerp(y1, y0, t);
        }
    }
}
