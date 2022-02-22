using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Triangle : Figure
    {
        public Vec2 a;
        public Vec2 b;
        public Vec2 c;

        public override bool test(Vec2 p)
        {
            return false;
        }
    }
}
