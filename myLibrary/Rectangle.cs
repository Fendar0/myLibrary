using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Rectangle : Figure
    {
        public Vec2 min;
        public Vec2 max;

        public override bool test(Vec2 p)
        {
            return false;
        }

    }
}
