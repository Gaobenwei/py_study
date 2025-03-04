using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snake.Lesson1;
namespace Snake.Lesson2
{
    class BeginScene:BeginOrEndBaseScene
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }
        protected override void EnterJDoSomething()
        {
            if(nowSelIndex == 0)
            {
                //开始游戏
                Game.ChangeScene(E_SceneTYpe.Game);
            }
            else
            {
                //结束游戏
                Environment.Exit(0);
            }
        }
    }
}
