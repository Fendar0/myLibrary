using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Circle : Figure
    {

        public Vec2 center;
        public float radius;

        public override bool test(Vec2 p)
        {
            return false;
        }

    }
}
