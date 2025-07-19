using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    class BlockInfo
    {
        public List<Position[]> list;
        private E_DrawType type;

        public E_DrawType Type
        {
            get 
            { 
                return this.type; 
            }
        }
        public BlockInfo(E_DrawType type)
        {
            this.type = type;
            list = new List<Position[]>();
            switch (type)
            {
                case E_DrawType.Cube:
                    list.Add(new Position[3]
                    {
                        new Position(2,0),
                        new Position(0,1),
                        new Position(2,1)
                    });
                    break;
                case E_DrawType.Line:
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(0,1),
                        new Position(0,2)
                    });
                    list.Add(new Position[3] {
                        new Position(-4,0),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-2),
                        new Position(0,-1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3] {
                        new Position(-2,0),
                        new Position(2,0),
                        new Position(4,0)
                    });
                    break;
                case E_DrawType.Tank:
                    list.Add(new Position[3] {
                        new Position(-2,0),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    list.Add(new Position[3] {
                        new Position(0,-1),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    break;
                case E_DrawType.Left_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,0),
                        new Position(2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(0,1),
                        new Position(-2,1)
                    });
                    list.Add(new Position[3]{
                       new Position(-2,-1),
                        new Position(-2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,-1),
                        new Position(-2,0)
                    });
                    break;
                case E_DrawType.Right_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(-2,0),
                        new Position(-2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(0,-1),
                        new Position(2,0)
                    });
                    list.Add(new Position[3]{
                        new Position(2,-1),
                        new Position(2,0),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,1),
                        new Position(2,1),
                        new Position(-2,0)
                    });
                    break;
                case E_DrawType.Left_Long_Ladder:
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(0,-1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(2,1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(-2,0),
                        new Position(-2,1)
                    });
                    break;
                case E_DrawType.Right_Long_Ladder:
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(0,1),
                        new Position(2,-1)
                    });
                    list.Add(new Position[3]{
                        new Position(2,0),
                        new Position(-2,0),
                        new Position(2,1)
                    });
                    list.Add(new Position[3]{
                        new Position(0,-1),
                        new Position(-2,1),
                        new Position(0,1)
                    });
                    list.Add(new Position[3]{
                        new Position(-2,-1),
                        new Position(-2,0),
                        new Position(2,0)
                    });
                    break;

                default:
                    break;
            }
        }

        public Position[] this[int index]
        {
            get {
                if (index < 0)
                {
                    return list[0];
                }
                else if (index >= list.Count)
                {
                    return list[list.Count - 1];
                }
                else
                {
                    return list[index];
                }
            }
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
