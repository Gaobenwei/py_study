using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    enum E_Change_Type
    {
        Left,
        Right,
    }
    class BlockWorker:IDraw
    {
        private List<DrawObject> blocks;
        private Dictionary<E_DrawType, BlockInfo> blockInfoDic;
        private BlockInfo nowBlockInfo;
        private int nowInfoIndex;
        public BlockWorker()
        {

            blockInfoDic = new Dictionary<E_DrawType, BlockInfo>()
            {
                { E_DrawType.Cube, new BlockInfo(E_DrawType.Cube) },
                { E_DrawType.Line, new BlockInfo(E_DrawType.Line) },
                { E_DrawType.Tank, new BlockInfo(E_DrawType.Tank) },
                { E_DrawType.Left_Ladder, new BlockInfo(E_DrawType.Left_Ladder) },
                { E_DrawType.Right_Ladder, new BlockInfo(E_DrawType.Right_Ladder) },
                { E_DrawType.Left_Long_Ladder, new BlockInfo(E_DrawType.Left_Long_Ladder) },
                { E_DrawType.Right_Long_Ladder, new BlockInfo(E_DrawType.Right_Long_Ladder) },
            };
            RandomCreateBlock(); 
        }

        public void RandomCreateBlock()
        {
            Random r = new Random();
            E_DrawType type = (E_DrawType)r.Next(1, 8);
            blocks = new List<DrawObject>()
            {
                new DrawObject(type),
                new DrawObject(type),
                new DrawObject(type),
                new DrawObject(type)
            };
            //初始化位置 原点随机 其他计算  随机四种形态里选择一种
            blocks[0].pos = new Position(24, -5);
            this.nowBlockInfo = blockInfoDic[type];
            nowInfoIndex = r.Next(0, nowBlockInfo.Count);
            Position[] pos = nowBlockInfo[nowInfoIndex]; 
            for(int i=0;i<pos.Length;++i)
            {
                blocks[i + 1].pos = blocks[0].pos + pos[i];
            }
        }

        public void CleanDraw()
        {
            for(int i=0;i<this.blocks.Count;++i)
            {
                blocks[i].CleanDraw();
            }
        }

        public void Change(E_Change_Type type)
        {
            //变形之前擦除，变形之后绘制
            CleanDraw();

            switch(type)
            {
                case E_Change_Type.Left:
                    nowInfoIndex--;
                    if(nowInfoIndex<0)
                    {
                        nowInfoIndex = nowBlockInfo.Count - 1;
                    }
                    break;
                case E_Change_Type.Right:
                    nowInfoIndex++;
                    if(nowInfoIndex>= nowBlockInfo.Count)
                    {
                        nowInfoIndex = 0;
                    }
                    break;
            }
            //得到索引为了得到对应形态的信息 得到新的三个方块的位置
            Position[] pos = this.nowBlockInfo[this.nowInfoIndex];
            for (int i = 0; i < pos.Length; ++i)
            {
                blocks[i + 1].pos = blocks[0].pos + pos[i];
            }

            Draw();
        }

        public bool CanChange(E_Change_Type type, Map map) //是否能够变化，即预判变化后是否和墙重合
        {
            int now_index = this.nowInfoIndex;
            switch (type)
            {
                case E_Change_Type.Left:
                    now_index--;
                    if (now_index < 0)
                    {
                        now_index = nowBlockInfo.Count - 1;
                    }
                    break;
                case E_Change_Type.Right:
                    now_index++;
                    if (now_index >= nowBlockInfo.Count)
                    {
                        now_index = 0;
                    }
                    break;
            }
            Position[] nowPos = this.nowBlockInfo[now_index];
            //判断 变化后的信息 是否符合
            // 判断是否超出地图边界 或者 是否和地图中的动态方块重合
            Position tempPos;
            for(int i=0;i<nowPos.Length;++i )
            {
                tempPos = blocks[0].pos + nowPos[i];
                //判断左右边界和下边界
                if(tempPos.x <2 || tempPos.x>=Game.w-2||
                    tempPos.y>=map.h)
                {
                    return false;
                }
            }

            for (int i = 0; i < nowPos.Length; ++i)
            {
                tempPos = blocks[0].pos + nowPos[i];
                //判断动态墙壁
               for(int j=0;j<map.dynamicWalls.Count;++j)
                {
                    if(tempPos == map.dynamicWalls[j].pos)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
        public void Draw()
        {
            for(int i=0;i<blocks.Count;++i)
            {
                blocks[i].Draw();
            }
        }

        public void MoveRL(E_Change_Type type)
        {
            //变形之前擦除，变形之后绘制
            CleanDraw();
            Position movePos = new Position(type == E_Change_Type.Left ? -2 : 2, 0);
            for(int i=0;i<blocks.Count;++i)
            {
                blocks[i].pos += movePos;
            }
            Draw();
        }

        public bool CanMoveRL(E_Change_Type type, Map map)
        {
            
            Position movePos = new Position(type == E_Change_Type.Left ? -2 : 2, 0);
            //判断 变化后的信息 是否符合
            // 判断是否超出地图边界 或者 是否和地图中的动态方块重合
            Position tempPos;
            for (int i = 0; i < blocks.Count; ++i)
            {
                tempPos = blocks[i].pos +movePos;
                //判断左右边界和下边界
                if (tempPos.x < 2 || tempPos.x >= Game.w - 2)
                {
                    return false;
                }
            }

            for (int i = 0; i < blocks.Count; ++i)
            {
                tempPos = blocks[i].pos + movePos;
                //判断动态墙壁
                for (int j = 0; j < map.dynamicWalls.Count; ++j)
                {
                    if (tempPos == map.dynamicWalls[j].pos)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void AutoMove()
        {
            CleanDraw();
            Position downMove = new Position(0, 1);
            for(int i=0;i<blocks.Count;++i)
            {
                blocks[i].pos += downMove;
            }
            Draw();
        }

        public bool CanMove(Map map)
        {
            Position tempPos;
            Position downMove = new Position(0, 1);
            for(int i=0;i<blocks.Count;++i)
            {
                tempPos = blocks[i].pos + downMove;
                if(tempPos.y>=map.h)
                {
                    //停下来 变成动态方块堆在下面
                    map.AddWalls(blocks);
                    RandomCreateBlock();
                    return false;
                }
            }

            for(int i=0;i<blocks.Count;++i)
            {
                tempPos = blocks[i].pos + downMove;
                for(int j=0;j<map.dynamicWalls.Count;++j)
                {
                    if (tempPos == map.dynamicWalls[j].pos)
                    {
                        map.AddWalls(blocks);
                        RandomCreateBlock();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
