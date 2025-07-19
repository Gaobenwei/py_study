using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    public enum E_SceneTYpe
    {
        Begin,
        Game,
        End,
    }
    class Game
    {
        public const int w = 50;
        public const int h = 35;
        public static ISceneUpdate nowScene; //当前选中的场景

        public void Init()
        {

        }
        public Game()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            ChangeScene(E_SceneTYpe.End);
        }
        //游戏开始
        public void Start()
        {
            //游戏主循环 负责场景的切换
            while (true)
            {
                if(nowScene !=null)
                {
                    nowScene.Update(); //这里用了多态，接口实际指向的对象的重写后的方法调用
                }
            }
        }

        public static void ChangeScene(E_SceneTYpe type)
        {
            //先擦除当前场景
            Console.Clear();
            switch(type)
            {
                case E_SceneTYpe.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneTYpe.Game:
                    nowScene = new GameScene();
                    break;
                case E_SceneTYpe.End:
                    nowScene = new EndScene();
                    break;
            }

        }
    }
}
