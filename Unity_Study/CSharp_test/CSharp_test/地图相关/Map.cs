using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    class Map:Draw
    {
        //固定墙壁＋动态墙壁
        private List<DrawObject> walls = new List<DrawObject>();
        public List<DrawObject> dynamicWalls = new List<DrawObject>();
        public int w; //动态墙壁的宽容量，即一行能装多少个
        public int h;

        private int[] recordInfo; //记录每一行有多少个快 ，index即为行号，满了（宽度-2）则消除一行，上面的全部下移， 数组更新

        public GameScene nowgamescene;
        public Map(GameScene nowgamescene)
        {
            this.nowgamescene = nowgamescene;
            h = Game.h - 6;
            recordInfo = new int[h];
            w = 0;
            for (int i = 0; i < Game.w; i += 2) //绘制横向的墙壁
            {
                walls.Add(new DrawObject(E_DrawType.Wall, i, h));
                ++w;
            }
            w -= 2;

            for (int i = 0; i < Game.h - 6; i++)
            {
                walls.Add(new DrawObject(E_DrawType.Wall, 0, i));
                walls.Add(new DrawObject(E_DrawType.Wall, Game.w - 2, i));
            }

        }

        public void Draw()
        {
            foreach(DrawObject a in walls)
            {
                a.Draw();
            }

            foreach(DrawObject a in dynamicWalls)
            {
                a.Draw();
            }
        }

        public void CleanDraw()
        {
            for(int i=0;i<dynamicWalls.Count;++i)
            {
                dynamicWalls[i].CleanDraw();
            }
        }

        public void AddWalls(List<DrawObject> walls)
        {
            for (int i = 0; i < walls.Count; ++i)
            {
                walls[i].ChangeType(E_DrawType.Wall);
                this.dynamicWalls.Add(walls[i]);
                if (walls[i].pos.y<=0)
                {
                    //关闭输入线程
                    nowgamescene.StopThread();
                    //切换到结束界面
                    Game.ChangeScene(E_SceneTYpe.End);
                    return;
                }
                recordInfo[h-walls[i].pos.y-1]++;
            }
            //先把之前的动态方块移除
            CleanDraw();
            //检测移除
            //在画新的
            CheckClear();
            Draw();
        }

        public bool CheckClear()
        {
            List<DrawObject> ready_clear = new List<DrawObject>();
            for(int i=0;i<recordInfo.Length;++i)
            {
                if (recordInfo[i]>=w)
                {
                    
                    for(int j=0;j<dynamicWalls.Count;++j)
                    {
                        //1 这一行的方块移除
                        if (h-1-dynamicWalls[j].pos.y == i)
                        {
                            ready_clear.Add(dynamicWalls[j]);
                        }

                        //2. 这一行上面的所有方块全部下移
                        else if (h - 1 - dynamicWalls[j].pos.y > i)
                        {
                            dynamicWalls[j].pos.y += 1;
                        }
                    }

                    //删除待删除的小方块
                    for(int z=0;z<ready_clear.Count;++z)
                    {
                        dynamicWalls.Remove(ready_clear[z]);
                    }
                    // 3 记录小方块数量的数组从上到下迁移
                    for(int j = i;j<recordInfo.Length-1;++j)
                    {
                        recordInfo[j] = recordInfo[j + 1];
                    }
                    //置空最上面行的方块数量
                    recordInfo[recordInfo.Length - 1] = 0;
                    //消除一行后 递归判断是否再消除一行是合适的
                    CheckClear();
                    break;
                }
            }
            return false;
        }
    }
}
