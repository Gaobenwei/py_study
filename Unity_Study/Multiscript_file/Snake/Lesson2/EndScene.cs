using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Lesson1;

namespace Snake.Lesson2
{
    class EndScene: BeginOrEndBaseScene
    {
        public EndScene()
        {
            strTitle = "结束游戏";
            strOne = "回到开始界面";
        }
        protected override void EnterJDoSomething()
        {
            if(nowSelIndex == 0)
            {
                //回到开始界面
                Game.ChangeScene(E_SceneTYpe.Begin);
            }
            else
            {
                //结束游戏
                Environment.Exit(0);
            }
        }
    }
}
