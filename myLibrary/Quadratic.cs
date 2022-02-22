using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Quadratic
    {
        public float a;
        public float b;
        public float c;

        public int Solve(out float[] x)
        {
            float d = Convert.ToSingle(Math.Pow(Convert.ToSingle(b), 2) - 4 * a * c);
            if (d < 0)
            {
                x = null;
                return 0;
            }
            if (d == 0)
            {
                x = new float[1];
                x[0] = (-b) / (2 * a);
                return 1;
            }
            else
            {
                x = new float[2];
                x[0] = -b + (Convert.ToSingle(Math.Sqrt(d))) / (2 * a);
                x[1] = -b - (Convert.ToSingle(Math.Sqrt(d))) / (2 * a);
                return 2;
            }
        }
    }
}
