// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace CSharpStudy_simple
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("不换行打印\n");
            //Console.Write("jixu");
            //Console.ReadLine(); //等待任意输入+回车结束
            //Console.ReadKey(); //任意输入键结束

            //#region 变量 and 常量
            //sbyte i_s = -12;
            //short i_short = 0;
            //int i_int = 1;
            //long i_long = 0;
            //byte i_byte = 0;
            //uint i_uint = 0;
            //ulong i_ulong = 0;
            //ushort i_ushort = 0;
            //float i_float = 0.1f; //有效数字 几位
            //double i_double = 0.0;
            //decimal i_decimal = 0.0m;
            //bool i_bool = false;
            //bool i_bool2 = true;
            //char i_char = 'a';
            //// 类型转换 有符号的无法隐式转换成无符号的，无符号转有符号只需要关注范围就行
            ////float 可以自动转都double 两者与decimal 都不可转
            ////float，double，decimal可以装任意整型 不会失真，有科学技术法
            ////整数不能装浮点数，bool几乎不能转任何，char可以隐式转换成整型，浮点，反之是不行
            //string str1 = @"hel\n";
            //Console.WriteLine(str1);
            //#endregion

            //#region Parase Convert
            ////parse后必须能够转换成相应的才行
            //int i_parase_1 = int.Parse("123");
            //short i_parse_2 = short.Parse("74");
            //bool i_parse_3 = bool.Parse("True");
            //Console.WriteLine(bool.Parse("false"));

            //Console.WriteLine(Convert.ToInt32("123"));
            //Console.WriteLine(Convert.ToInt64(1.456456));
            //Console.WriteLine(Convert.ToInt64('a'));
            //Console.WriteLine(Convert.ToInt16('a'));

            //Console.WriteLine(Convert.ToByte('a'));
            //Console.WriteLine(Convert.ToUInt16('a'));

            //Console.WriteLine(Convert.ToSingle("13.26"));
            //Console.WriteLine(Convert.ToDouble("23.4545"));
            //Console.WriteLine(Convert.ToDecimal("41564.5246546"));
            //Console.WriteLine(Convert.ToBoolean("true"));
            //Console.WriteLine(Convert.ToString(123));

            //string str_to_string = 1.ToString();
            ////字符串拼接 会自动调用


            //#endregion

            //#region try catch finally
            //try
            //{
            //    string str_try = Console.ReadLine();
            //    //int i = int.Parse(str_try);
            //    int i_try=Convert.ToInt32(str_try);
            //    Console.WriteLine(i_try);
            //}
            //catch { Console.WriteLine("输入不合法"); }
            //finally { Console.WriteLine("无所谓会不会douzai "); }
            //#endregion

            //#region str.Format
            //string str_Format = string.Format("0=:{0},1={1},2={2}", 18, "nan", false);
            //Console.WriteLine(str_Format);
            //Console.Write("0=:{0},1={1},2={2}\n", 18, "nan", false);
            //#endregion

            //Console.Write("变量：" + i_short + "\n");
            //Console.Write(i_float + "\n");
            //Console.Write(i_bool + "-" + i_bool2+"\n");
            //Console.WriteLine("char 所占据的字节：" + sizeof(char));
            #region 控制台操作
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);
            Console.SetWindowSize(100, 100); //设置窗口大小
            Console.SetBufferSize(1000, 1000); //设置缓冲区大小
            Console.SetCursorPosition(10, 10); //设置光标位置
            Console.WriteLine("光标位置:"+10);

            //设置颜色
            Console.ForegroundColor = ConsoleColor.Red; //前景色
            Console.WriteLine("输入任意字符关闭");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue; //背景色9
            //光标的显隐
            Console.CursorVisible = false;
            Console.ReadLine();
            Environment.Exit(0); //退出程序
            //Console.Clear();
            #endregion



        }
    };
}