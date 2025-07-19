using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    enum E_DrawType
    {
        /// <summary>
        /// 墙壁
        /// </summary>
        Wall,
        /// <summary>
        /// 正方形方块
        /// </summary>
        Cube,
        /// <summary>
        /// 直线
        /// </summary>
        Line,
        /// <summary>
        /// 坦克
        /// </summary>
        Tank,
        /// <summary>
        /// 左梯子
        /// </summary>
        Left_Ladder,
        /// <summary>
        /// 右梯子
        /// </summary>
        Right_Ladder,
        /// <summary>
        /// 左长梯子
        /// </summary>
        Left_Long_Ladder,
        /// <summary>
        /// 右长梯子
        /// </summary>
        Right_Long_Ladder,
    }
    class DrawObject:Draw
    {
        public Position pos;
        public E_DrawType type;
        public DrawObject(E_DrawType type)
        {
            this.type = type;
        }
        public void Draw()
        {
            if(pos.y<0)
                return;
            //光标位置调整+绘制不停的类型
            Console.SetCursorPosition(pos.x, pos.y);
            switch (type)
            {
                case E_DrawType.Wall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case E_DrawType.Cube:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case E_DrawType.Line:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case E_DrawType.Tank:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case E_DrawType.Left_Ladder:
                case E_DrawType.Right_Ladder:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case E_DrawType.Left_Long_Ladder:
                case E_DrawType.Right_Long_Ladder:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            Console.Write("■");
        }

        public void CleanDraw()
        {
            if (pos.y < 0)
                return;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("  ");
        }

        public void ChangeType(E_DrawType type)
        {
            this.type = type;
        }
        public DrawObject(E_DrawType type, int x, int y)
        {
            this.type = type;
            this.pos = new Position(x, y);
        }
    }
}
