using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    public class Figure
    {
        public RGB color;
        virtual public bool test(Vec2 p)
        {
            return false;
        }
    }
}
