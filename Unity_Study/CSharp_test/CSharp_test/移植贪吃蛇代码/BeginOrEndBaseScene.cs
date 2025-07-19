using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_test
{
    abstract class BeginOrEndBaseScene:ISceneUpdate
    {
        protected abstract void EnterJDoSomething(); //按j键后的操作，对应两种的开始或结束，所以设置成抽象方法来具体重写
        protected int nowSelIndex=0;
        protected string strTitle;
        protected string strOne;
        public void Update()
        {
            //Console.SetCursorPosition(0, 0);
            //Console.WriteLine("开始或结束场景");
            // 选择开始或结束 键盘输入
            // 显示标题 下方选项 检测输入   
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Game.w / 2 - strTitle.Length, 5);
            Console.WriteLine(strTitle);
            Console.SetCursorPosition(Game.w / 2 - strOne.Length, 8);
            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);
            Console.SetCursorPosition(Game.w / 2 - 2, 10);
            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束");
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    nowSelIndex--;
                    if (nowSelIndex < 0)
                    {
                        nowSelIndex = 0;
                    }
                    break;
                case ConsoleKey.S:
                    nowSelIndex++;
                    if (nowSelIndex > 1)
                    {
                        nowSelIndex = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomething();
                    break;
            }
        }
    }
}
