using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_test
{
    class GameScene : ISceneUpdate
    {
        public Map map;
        public BlockWorker worker;
        //public Thread inputThread;
        //bool isrunning;
        public GameScene() 
        {
            map = new Map(this);
            worker = new BlockWorker();

            InputThread.Instance.inputEvent += CheckInputThread;
            //inputThread = new Thread(CheckInputThread);
            //inputThread.IsBackground = true;
            //isrunning = true;
            //inputThread.Start();

        }

        public void CheckInputThread()
        {

                if (Console.KeyAvailable)
                {
                    lock(worker)
                    {
                        switch (Console.ReadKey(true).Key)
                        {

                            case ConsoleKey.LeftArrow:
                                //判断能不能变形 才变形
                                if (worker.CanChange(E_Change_Type.Left, this.map))
                                    worker.Change(E_Change_Type.Left);
                                break;
                            case ConsoleKey.RightArrow:
                                if (worker.CanChange(E_Change_Type.Right, this.map))
                                    worker.Change(E_Change_Type.Right);
                                break;

                            case ConsoleKey.A:
                                if (worker.CanMoveRL(E_Change_Type.Left, this.map))
                                    worker.MoveRL(E_Change_Type.Left);
                                break;

                            case ConsoleKey.D:
                                if (worker.CanMoveRL(E_Change_Type.Right, this.map))
                                    worker.MoveRL(E_Change_Type.Right);
                                break;
                            case ConsoleKey.S:
                                if (worker.CanMove(this.map))
                                {
                                    worker.AutoMove();
                                }
                                break;
                        }
                    }
                   
                }
            
            
        }
        public void Update()
        {
            lock(worker)
            {
                map.Draw();
                worker.Draw();
                if (worker.CanMove(this.map))
                {
                    worker.AutoMove();
                }
            }
            //线程休眠
            Thread.Sleep(50);
 
            //Game.ChangeScene(E_SceneTYpe.End);
        }

        public void StopThread()
        {
            //isrunning = false;
            InputThread.Instance.inputEvent -= CheckInputThread;
            //inputThread = null;
        }
    }
}
