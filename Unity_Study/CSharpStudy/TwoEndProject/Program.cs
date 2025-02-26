using System.Diagnostics;
using System.Numerics;
using System.Xml.Serialization;

namespace TwoEndProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1控制台初始化
            int w = 50;
            int h = 30;
            ConsoleInit(w, h);

            #region 2场景选择
            E_SceneType nowSceneType = E_SceneType.Begin;
            while (true)
            {
                switch (nowSceneType)
                {
                    case E_SceneType.Begin:
                        Console.Clear();
                        BeginOrEndScene(w, h, ref nowSceneType);
                        break;
                    case E_SceneType.End:
                        Console.Clear();
                        BeginOrEndScene(w, h, ref nowSceneType);
                        break;
                    case E_SceneType.Game:
                        Console.Clear();
                        GameScene(w, h, ref nowSceneType);  
                        break;
                    default:
                        break;
                }
            }
            #endregion
        }
        #region 控制台初始化
        static void ConsoleInit(int w, int h )
        {
            //基础设置 光标隐藏 + 窗口大小
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
        }
        #endregion
         
        #region 3开始场景逻辑 + j结束场景逻辑
        static void BeginOrEndScene(int w,int h, ref E_SceneType nowType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(nowType == E_SceneType.Begin?w / 2 - 3:w/2-4, 8);
            Console.Write(nowType==E_SceneType.Begin?"飞行棋":"游戏结束");
            int nowSelIndex = 0; //当前选项的编号
            bool ifQuitBegin = false; //是否退出开始场景
            while (true)
            {
                Console.SetCursorPosition(nowType == E_SceneType.Begin?w / 2 - 4:w/2-5, 13);
                Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(nowType == E_SceneType.Begin?"开始游戏":"回到主菜单");
                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");
                // 通过readkey可以得到一个有用的枚举类型
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        --nowSelIndex;
                        if(nowSelIndex<0)
                        {
                            nowSelIndex = 0;
                        }
                        break;
                    case ConsoleKey.S:
                        ++nowSelIndex;
                        if (nowSelIndex>1)
                        {
                            nowSelIndex = 1;
                        }
                        break;
                    case ConsoleKey.J:
                        if (nowSelIndex==0)
                        {
                            //进入游戏
                            nowType = (nowType == E_SceneType.Begin)?E_SceneType.Game:E_SceneType.Begin ;
                            ifQuitBegin = true;
                        }
                        else
                        {
                            //退出游戏
                            Environment.Exit(0);
                        }
                        break; 
                    default:
                        break;
                }
                if (ifQuitBegin)
                {
                    break;
                }
            }
        }
        #endregion

        #region 游戏场景逻辑
        static void GameScene(int w,int h, ref E_SceneType nowType)
        {
            //绘制不变的内容
            DrawWall(w,h);
            Map map = new Map(14, 3, 80); //初始化地图信息
            map.Draw();
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayer(player, computer, map);
            bool isGameover = false;
            while (true) //游戏逻辑循环
            {//检测输入 扔色子的逻辑 绘制地图 绘制玩家 是否结束游戏 玩家一次+电脑一次
                //Console.ReadKey(true);
                //isGameover=RandomMove(w, h, ref player, ref computer, map);
                //map.Draw();
                //DrawPlayer(player, computer, map);
                //if(isGameover )
                //{
                //    //卡主 按任意键结束
                //    Console.ReadKey(true);
                //    nowType = E_SceneType.End;
                //    break;
                //}

                //玩家扔色子
                if (PlayerRandomMove(w, h, ref player, ref computer, map, ref nowType))
                {
                    break;
                }

                //PlayerRandomMove(w, h, ref player, ref computer, map, ref nowType);
                //Console.ReadKey(true);
                //isGameover = RandomMove(w, h, ref computer, ref player, map);
                //map.Draw();
                //DrawPlayer(player, computer, map);
                //if (isGameover)
                //{
                //    Console.ReadKey(true);
                //    nowType = E_SceneType.End;
                //    break;
                //}

                //电脑扔色子
                if (PlayerRandomMove(w, h, ref computer, ref player, map, ref nowType))
                {
                    break;
                }
            }
        }

        static bool PlayerRandomMove(int w,int h,ref Player p,ref Player p2,Map map,ref E_SceneType nowType)
        {
            Console.ReadKey(true);
            bool isGameover = RandomMove(w, h, ref p, ref p2, map);
            map.Draw();
            DrawPlayer(p, p2, map);
            if (isGameover)
            {
                //卡主 按任意键结束
                Console.ReadKey(true);
                nowType = E_SceneType.End;
            }
            return isGameover;
        }
        #endregion

        #region 4.绘制不变的内容（红墙 提示等）
        static void DrawWall(int w,int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < w; i+=2)
            {
                
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, h-1);
                Console.Write("■");
                Console.SetCursorPosition(i, h-6);
                Console.Write("■");
                Console.SetCursorPosition(i, h-11);
                Console.Write("■");
            }

            for (int j = 0; j < h; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write("■");
                Console.SetCursorPosition(w - 2, j);
                Console.Write("■");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 10);
            Console.Write("□：普通格子");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("‖：暂停，一回合不动");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●：炸弹，倒退5格");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("¤：时空隧道，随机倒退，暂停，换位置");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("★：玩家");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("▲：电脑");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("◎：玩家和电脑重合");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始扔骰子");
        }

        #endregion

        #region 7 绘制玩家和电脑
        static void DrawPlayer(Player player, Player computer,Map map)
        {
            if(player.nowIndex == computer.nowIndex)
            {
                Console.SetCursorPosition(map.grids[player.nowIndex].pos.x, map.grids[player.nowIndex].pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("◎");
            }
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }
        #endregion

        #region 擦除信息
        static void cleanInfo(int h)
        {
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                           ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                           ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                           ");
            Console.SetCursorPosition(2, h - 2 );
            Console.Write("                                           ");
        }
        #endregion

        #region 扔色子
        /// <summary>
        /// 扔色子函数
        /// </summary>
        /// <param name="w">窗口款</param>
        /// <param name="h">窗口高</param>
        /// <param name="p">扔的对象</param>
        /// <param name="map">地图信息</param>
        /// <returns>默认返回false 代表没有结束</returns>
        static bool RandomMove(int w,int h, ref Player p,ref Player p2, Map map) 
        {
            //擦除之前写的提示信息
            cleanInfo(h);
            Console.ForegroundColor=p.type==E_PlayerType.Player? ConsoleColor.Cyan : ConsoleColor.Magenta; //根据玩家信息决定提示颜色

            if (p.isPause) 
            {
                Console.SetCursorPosition(2, h - 5);
                Console.Write("处于暂停回合，{0}需要暂停一回合", p.type == E_PlayerType.Player ? "玩家" : "电脑");
                Console.SetCursorPosition(2, h - 4);
                Console.Write("按任意键，让{0}开始扔色子", p.type == E_PlayerType.Computer ? "玩家" : "电脑");
                p.isPause = false;
                return false; 
            }
            Random r = new Random();
            int randomNum=r.Next(1, 7);
            p.nowIndex+= randomNum;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出来的点数是{1}",p.type==E_PlayerType.Player?"玩家":"电脑",randomNum);
            //是否到了终点
            if (p.nowIndex>=map.grids.Length-1)
            {
                p.nowIndex=map.grids.Length - 1;
                if(p.type == E_PlayerType.Player)
                {
                    Console.SetCursorPosition(2, h - 4);
                    Console.Write("玩家到达了终点，游戏结束");
                }
                else
                {
                    Console.SetCursorPosition(2, h - 4);
                    Console.Write("电脑到达了终点，游戏结束");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("请安任意键结束");
                return true;
            }
            else
            {
                //判断到了怎样的格子 有不同的效果
                Grid grid = map.grids[p.nowIndex];
                switch (grid.type)
                {
                    case E_Grid_type.Normal:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了安全位置", p.type == E_PlayerType.Player ? "玩家" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键，让{0}开始扔色子", p.type == E_PlayerType.Computer ? "玩家" : "电脑");
                        break;
                    case E_Grid_type.Boom:
                        p.nowIndex -= 5;
                        if (p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}逮到了炸弹，后退5  ", p.type == E_PlayerType.Player ? "玩家" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键，让{0}开始扔色子", p.type == E_PlayerType.Computer ? "玩家" : "电脑");
                        break;
                    case E_Grid_type.Pause:
                        p.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了暂停点，暂停一回合", p.type == E_PlayerType.Player ? "玩家" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("按任意键，让{0}开始扔色子", p.type == E_PlayerType.Computer ? "玩家" : "电脑");
                        break;
                    case E_Grid_type.Tunnel:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}逮到了失控碎掉  ", p.type == E_PlayerType.Player ? "玩家" : "电脑");
                        randomNum = r.Next(1, 91);
                        if(randomNum <= 30)
                        {
                            p.nowIndex -= 5;
                            if (p.nowIndex < 0)
                            {
                                p.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退陷阱");
                        }
                        else if (randomNum <= 60)
                        {
                            p.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停一回合");
                        }
                        else
                        {//换位置
                            int temp = p.nowIndex;
                            p.nowIndex = p2.nowIndex;
                            p2.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("惊喜 交换位置");
                        }
                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("按任意键，让{0}开始扔色子", p.type == E_PlayerType.Computer ? "玩家" : "电脑");
                        break;
                    default:
                        break;
                }
            }
            return false; //默认没有结束
        }
        #endregion

    }
    #region 场景枚举
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End

    }
    #endregion

    #region 5格子枚举+格子结构体
    enum E_Grid_type
    {
        /// <summary>
        /// 普通格子
        /// </summary>
        Normal, 
        /// <summary>
        /// 炸弹
        /// </summary>
        Boom,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 时空隧道
        /// </summary>
        Tunnel
    }
    struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int x, int y) { this.x = x; this.y = y; }
    }
    struct Grid
    {
        public E_Grid_type type;
        public Vector2 pos;
        public Grid(int x,int y, E_Grid_type type)
        {
            this.pos = new Vector2(x, y);
            this.type = type;
        }
        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            switch (type)
            {
                case E_Grid_type.Normal:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("□");
                    break;
                case E_Grid_type.Boom:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("●");
                    break;
                case E_Grid_type.Pause:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("‖");
                    break;
                case E_Grid_type.Tunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("¤");
                    break;
                default:
                    break;
                }
            }
    }
    #endregion

    #region 地图结构体
    struct Map
    {
        public Grid[] grids;
        public Map(int x,int y,int num)
        {//初始化了所有格子的类型和位置属性 
            //用于位置改变计数的变量
            //表示x的变化次数
            int indexX = 0;
            //表示y的变化次数
            int indexY = 0;
            //x的步长
            int stepNum = 2;

            grids = new Grid[num];
            Random r=new Random();
            int randomnumber = 0;
            for (int i=0;i<num; i++)
            {
                randomnumber = r.Next(0, 101);
                if(randomnumber<85 ||i==0 || i==num-1)
                {
                    //普通格子多一点，首位必须是普通格子
                    grids[i].type = E_Grid_type.Normal;
                }
                else if (randomnumber>=85 && randomnumber < 90)
                {
                    grids[i].type = E_Grid_type.Boom;
                }
                else if(randomnumber>=90 &&randomnumber < 95)
                {
                    grids[i].type = E_Grid_type.Pause;
                }
                else
                {
                    grids[i].type = E_Grid_type.Tunnel;
                }
                grids[i].pos = new Vector2(x, y);
                if (indexX == 10)
                {
                    y += 1;
                    ++indexY; //加一次Y记一次数
                    if(indexY ==2)
                    {
                        //y变化两次后，x变化次数记0
                        indexX = 0;
                        indexY = 0;
                        stepNum = -stepNum;
                    }
                }
                else
                {
                    x += stepNum;
                    ++indexX; //加一次X记一次数
                }
            }
        }
        public void Draw()
        {
            for(int i=0;i<grids.Length;++i)
            {
                grids[i].Draw();
            }
        }
    }
    #endregion

    #region 7.玩家枚举和玩家结构体
    enum E_PlayerType
    {
        Player,
        Computer,
    }

    struct Player
    {
        public E_PlayerType type;
        public int nowIndex; //当前所在地图哪一个格子的索引
        public bool isPause; //是否暂停
        public Player(int index,E_PlayerType type)
        {
            this.type = type;
            this.isPause = false;
            this.nowIndex = index;
        }

        public void Draw(Map maoInfo)
        {
            //设置位置和颜色
            Grid grid = maoInfo.grids[this.nowIndex];
            Console.SetCursorPosition(grid.pos.x, grid.pos.y);
            
            switch(type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case E_PlayerType.Computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;
            }
        }
    }
    #endregion
}