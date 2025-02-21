using System.Diagnostics;
using System.Runtime;

namespace OneEndProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;
            //通过两个变量来存储 舞台的大小
            int w = 50;
            int h = 30;
            //设置舞台（控制台）的大小
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 2多个场景
            //当前所在场景的编号
            int nowSceneID = 1;

            string gameoverinfo = "";
            while (true)
            {
                //不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    //开始场景
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("唐老狮营救公主");
                        //当前选项的编号
                        int nowSelIndex = 0;  
                        while (true)
                        {
                            //用一个标识  来处理 想要在while循环内部的switch逻辑执行时 希望退出外层while循环时
                            // 改变标识即可
                            bool isQuitWhile = false;
                            // 显示 内容
                            //先设置光标位置 再显示内容
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            //根据当前选择的编号 来决定 是否变色
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            // 检测 输入
                            // 检测玩家 输入的一个键内容 并且不会再控制台上显示输入的内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch(input) 
                            {
                                case 'w':
                                case 'W':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    } 
                                    break;
                                case 's':
                                case 'S':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //1.改变当前选择的场景ID
                                        nowSceneID = 2;
                                        //2.要退出 内层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            //可以跳出循环了
                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        break;
                    //游戏场景
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < w; i += 2)
                        {
                            //上方墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            //下方墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                            //中间墙
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                        }
                        for (int i = 0; i < h; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            //右边的墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #region 5 boss属性相关
                        int bossX = 24;
                        int bossY = 15;
                        int bossAtkMin = 7 ;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        //申明一个 颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion
                        #region 6 玩家属性相关
                        int playerX = 4;
                        int playerY = 5;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //玩家输入的内容 外面申明 节约性能
                        char playerInput='\0';
                        #endregion
                        #region 7 人质属性相关
                        int hostageX = 24;
                        int hostageY = 5;
                        string hostageIcon = "♀";
                        const ConsoleColor hostageColor = ConsoleColor.Magenta;
                        #endregion

                        //玩家战斗标志
                        bool isFight = false;
                        bool isOver = false; //游戏是否结束,从while循环内部的switch中跳出
                        //游戏场景死循环，检测玩家输入
                        while (true)
                        {
                            //绘制BOSS
                            if (bossHp > 0)
                            {
                                //绘制BOSS图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            else
                            {
                                //人质
                                Console.SetCursorPosition(hostageX, hostageY);
                                Console.ForegroundColor = hostageColor;
                                Console.Write(hostageIcon);
                            }
                            //绘制玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            playerInput = Console.ReadKey(true).KeyChar; 
                            if(isFight)
                            {
                                //战斗逻辑
                                if (playerInput == 'J' || playerInput == 'j')
                                {
                                    //判断玩家是否胜利或者失败 
                                    if (playerHp <= 0)
                                    {
                                        //游戏结束
                                        nowSceneID = 3;
                                        gameoverinfo = "你被boss击败了，游戏结束"; 
                                        break;
                                    }
                                    else if(bossHp<=0)
                                    {
                                        //胜利 擦除boss
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write("  ");
                                        isFight = false;
                                    }
                                    else //战斗逻辑
                                    {
                                        Random r = new Random();
                                        int atk = r.Next(playerAtkMin, playerAtkMax);
                                        bossHp -= atk;
                                        Console.ForegroundColor = ConsoleColor.Green;

                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                             ");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("你对boss造成了{0}点伤害，boss剩余血量为{1}", atk, bossHp);
                                        if (bossHp > 0)
                                        {
                                            atk = r.Next(bossAtkMin, bossAtkMax);
                                            playerHp -= atk;
                                            Console.ForegroundColor = ConsoleColor.Yellow;

                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");

                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("你被boss击败了，游戏结束");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("你对boss造成了{0}点伤害，boss剩余血量为{1}", atk, playerHp);
                                            }
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");

                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("你战胜了boss，接人");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("前往人质位置，J继续");

                                        }
                                    }
                                }
                            }
                            else //非战斗状态，控制玩家移动
                            {
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write("  ");
                                switch (playerInput)
                                {
                                    case 'w':
                                    case 'W':
                                        playerY -= 1;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        //位置如果和boss重合了 并且boss没有死
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            ++playerY;
                                        }
                                        else if (playerX==hostageX && playerY==hostageY && bossHp<=0)
                                        {
                                            //拉回去
                                            ++playerY;
                                        }
                                        break;
                                    case 's':
                                    case 'S':
                                        playerY += 1;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            --playerY;
                                        }
                                        else if (playerX == hostageX && playerY == hostageY && bossHp <= 0)
                                        {
                                            //拉回去
                                            --playerY;
                                        }
                                        break;
                                    case 'a':
                                    case 'A':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX += 2;
                                        }
                                        else if (playerX == hostageX && playerY == hostageY && bossHp <= 0)
                                        {
                                            //拉回去
                                            playerX += 2;
                                        }
                                        break;
                                    case 'd':
                                    case 'D':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            playerX -= 2;
                                        }
                                        else if (playerX == hostageX && playerY == hostageY && bossHp <= 0)
                                        {
                                            //拉回去
                                            playerX -= 2;
                                        }
                                        break;
                                    case 'J':
                                    case 'j':
                                        //玩家攻击 暂时不能移动
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            isFight = true;
                                            //可以玩家攻击
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("开始和boss战斗，J继续");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("玩家血量{0}", playerHp);
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("boss血量{0}", bossHp);
                                        }
                                        else if((playerX == hostageX && playerY == hostageY - 1 ||
                                            playerX == hostageX && playerY == hostageY + 1 ||
                                            playerX == hostageX - 2 && playerY == hostageY ||
                                            playerX == hostageX + 2 && playerY == hostageY) && bossHp <= 0)
                                        {//人质身边，接人m
                                            nowSceneID = 3;
                                            gameoverinfo = "恭喜你，成功营救公主";
                                            isOver = true;
                                            break;
                                        }
                                        break;
                                }
                            }
                            if (isOver)
                            { //跳出while循环
                                break;
                            }
                        } 
                        break;
                    //结束场景
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.Write("gameover");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(w / 2 - 4, 7);
                        Console.Write(gameoverinfo);  

                        int nowSelIndex2 = 0;
                        while (true)
                        {
                            bool isQuitWhile_ = false;
                            Console.SetCursorPosition(w / 2 - 6, 9);
                            Console.ForegroundColor = nowSelIndex2 == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");
                            Console.SetCursorPosition(w / 2 - 4, 11);
                            Console.ForegroundColor = nowSelIndex2 == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            char input = Console.ReadKey(true).KeyChar;
                            switch(input)
                            {
                                case 'w':
                                case 'W':
                                    --nowSelIndex2; 
                                    if (nowSelIndex2 < 0)
                                    {
                                        nowSelIndex2 = 0;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    ++nowSelIndex2;
                                    if (nowSelIndex2 > 1)
                                    {
                                        nowSelIndex2 = 1;
                                    }  
                                    break;
                                case 'j':
                                case 'J':
                                    if(nowSelIndex2 == 0)
                                    {
                                        nowSceneID = 1;
                                        isQuitWhile_ = true;
                                        break;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile_)
                            {
                                break;
                            }
                        }
                        break;
                }
            }
            #endregion
        }
    }
}
