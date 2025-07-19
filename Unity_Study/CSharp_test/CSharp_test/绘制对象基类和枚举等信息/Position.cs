using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    struct Position
    {
        public int x;
        public int y;
        public Position(int x_, int y_)
        {
            this.y = y_;
            this.x = x_;
        }

        //比较相关信息
        public static bool operator==(Position a, Position b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            return false;
        }

        public static bool operator!=(Position a, Position b)
        {
            return !(a == b);
        }

        public static Position operator+(Position a, Position b)
        {
            return new Position(a.x + b.x, a.y + b.y);
        }
    }
}
