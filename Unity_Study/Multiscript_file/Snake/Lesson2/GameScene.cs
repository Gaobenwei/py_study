using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Lesson1;
using Snake.Lesson4;
using Snake.Lesson5;
using Snake.Lesson6;

namespace Snake.Lesson2
{
    class GameScene : ISceneUpdate
    {
        public Map map;
        Snake.Lesson6.Snake snake ;
        Food food;
        int updateIndex = 0;
        public GameScene() 
        { 
            this.map=new Map();
            snake = new Lesson6.Snake(40, 10);
            this.food= new Food(snake);
        }
        public void Update()
        {
            if (updateIndex%10000 == 0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();
                //检测蛇头和食物的碰撞 撞墙
                if(snake.CheckEnd(map))
                {
                    Game.ChangeScene(E_SceneTYpe.End);
                }
                snake.CheckEatFood(food);
                updateIndex = 0;
            }
            ++updateIndex;

            // 检测输入输出不能放在间隔帧里面处理 应该每次都检测 才准确
            //在控制台中 检测玩家输入 让程序不被检测卡主
            //判断 有没有键盘输入 如果有 才为true
            if(Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                }

            }
        }
    }
}
