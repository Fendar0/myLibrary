using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Vec2
    {
        public float x;
        public float y;
        public Vec2()
        {
            x = 0.0f;
            y = 0.0f;
        }

        public Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        static public Vec2 operator -(Vec2 a, Vec2 b)
        {
            return a - b;
        }

        public float Dot(Vec2 v)
        {
            return Convert.ToSingle(v);
        }
    }
}
