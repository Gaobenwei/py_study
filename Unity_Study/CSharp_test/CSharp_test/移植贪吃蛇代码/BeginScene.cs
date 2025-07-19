using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharp_test
{
    class BeginScene:BeginOrEndBaseScene
    {
        public BeginScene()
        {
            strTitle = "俄罗斯方块";
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
