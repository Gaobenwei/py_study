// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Runtime.CompilerServices;
namespace Lesson
{
    /// <summary>
    /// 
    /// </summary>
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //#region 控制台练习
    //        ////该背景颜色
    //        //Console.BackgroundColor = ConsoleColor.Red;
    //        //Console.Clear();
    //        ////字体颜色
    //        //Console.ForegroundColor = ConsoleColor.Yellow;
    //        //Console.CursorVisible=false;
    //        //int x = 0, y = 0;

    //        //char c = '\0';
    //        //while (true)
    //        //{
    //        //    //清空的方式刷新
    //        //    //Console.Clear();
    //        //    //

    //        //    Console.SetCursorPosition(x, y);
    //        //    Console.Write("■");
    //        //    c = Console.ReadKey(true).KeyChar; //不显示输入

    //        //    //把之前的擦掉的方式
    //        //    Console.SetCursorPosition(x, y);
    //        //    Console.Write(" "); 
    //        //    switch (c)
    //        //    {
    //        //        case 'w':
    //        //        case 'W':
    //        //            y -= 1;
    //        //            y=y< 0 ? 0 : y;
    //        //            break;
    //        //        case 's':
    //        //        case 'S':
    //        //            y += 1;
    //        //            y=y>Console.BufferHeight - 1 ? Console.BufferHeight - 1 : y;
    //        //            break;
    //        //        case 'a':
    //        //        case 'A':
    //        //            x -= 1;
    //        //            x= x < 0 ? 0 : x;
    //        //            break;
    //        //        case 'd':
    //        //        case 'D':
    //        //            x += 1;
    //        //            x = x > Console.BufferWidth - 1 ? Console.BufferWidth - 1 : x;
    //        //            break;
    //        //    }
    //        //}
    //        //#endregion

    //        //#region 随机数练习
    //        //Random r_ = new Random();
    //        //int i_random = r_.Next();
    //        //int i_random2 = r_.Next(0, 100);
    //        //Console.WriteLine("随机数练习题");
    //        ////唐老狮打小怪兽
    //        ////唐老狮攻击力为8~12之间的一个值
    //        ////小怪兽防御为10，血量为20
    //        ////在控制台中通过打印信息表现唐老狮打小怪兽的过程
    //        ////描述小怪兽的掉血情况
    //        ////伤害计算公式：攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值

    //        ////知识点：循环、随机数等等

    //        //int monsterDef = 10;
    //        //int monsterHp = 20;
    //        //int teacherTangAtk = 0;
    //        //Random r = new Random();

    //        //while (true)
    //        //{
    //        //    teacherTangAtk = r.Next(8, 13);
    //        //    if (teacherTangAtk > monsterDef)
    //        //    {
    //        //        //减血攻击力和防御力的差值
    //        //        //monsterHp = monsterHp - (teacherTangAtk - monsterDef);
    //        //        monsterHp -= teacherTangAtk - monsterDef;
    //        //        Console.WriteLine("唐老狮本次攻击力为{0},造成{1}伤害,怪物剩{2}血",
    //        //            teacherTangAtk, teacherTangAtk - monsterDef, monsterHp);
    //        //        if (monsterHp <= 0)
    //        //        {
    //        //            break;
    //        //        }
    //        //    }
    //        //    else
    //        //    {
    //        //        Console.WriteLine("唐老狮本次攻击力为{0},不足以造成伤害", teacherTangAtk);
    //        //    }

    //        //    Console.WriteLine("请按任意键继续攻击");
    //        //    Console.ReadKey(true);
    //        //    Console.Clear();
    //        //}

    //        //Console.WriteLine("怪物已死亡");
    //        //#endregion
    //    }
    //};
}

namespace Lesson_B_1
{

    enum E_QQType
    {
        /// <summary>
        /// QQ状态
        /// </summary>
        OnLine,
        Leave,
        Busy,
        Invisible,
    }

    enum E_CafeType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        M,
        /// <summary>
        /// 大杯
        /// </summary>
        B,
        /// <summary>
        /// 超大杯
        /// </summary>
        S,
    }

    enum E_Sex
    {
        Man,
        Woman,
    }
    enum E_Occupation
    {
        /// <summary>
        /// 战士
        /// </summary>
        Warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Master,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举，练习");
            #region enum 练习1
            //定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
            //try
            //{
            //    Console.WriteLine("请输入QQ的状态(0在线，1离开，2忙，3隐身)");
            //    int type = int.Parse(Console.ReadLine());
            //    E_QQType qqType = (E_QQType)type;
            //    Console.WriteLine(qqType);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region enum 练习2
            //try
            //{
            //    Console.WriteLine("请输入咖啡杯型(0中杯，1大杯，2超大杯)");
            //    int cafeType = int.Parse(Console.ReadLine());
            //    E_CafeType cType = (E_CafeType)cafeType;
            //    switch(cType)
            //    {
            //        case E_CafeType.M:
            //            Console.WriteLine("中杯");
            //            break;
            //        case E_CafeType.B:
            //            Console.WriteLine("大杯");
            //            break;
            //        case E_CafeType.S:
            //            Console.WriteLine("超大杯");
            //            break;
            //        default:
            //            Console.WriteLine("输入正确类型");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region enum 练习3
            //try
            //{
            //    Console.WriteLine("请选择性别（男0 女1）");
            //    E_Sex sex = (E_Sex)int.Parse(Console.ReadLine());
            //    string sexStr = "";
            //    int atk = 0;
            //    int def = 0;
            //    switch (sex)
            //    {
            //        case E_Sex.Man:
            //            sexStr = "男性";
            //            atk += 50;
            //            def += 100;
            //            break;
            //        case E_Sex.Woman:
            //            sexStr = "女性";
            //            atk += 150;
            //            def += 20;
            //            break;
            //    }
            //    Console.WriteLine("请选择职业（战士0 猎人1 法师2）");
            //    E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
            //    string skill = "";
            //    string occupation = "";
            //    switch (o)
            //    {
            //        case E_Occupation.Warrior:
            //            atk += 20;
            //            def += 100;
            //            skill = "冲锋";
            //            occupation = "战士";
            //            break;
            //        case E_Occupation.Hunter:
            //            atk += 120;
            //            def += 30;
            //            skill = "假死";
            //            occupation = "猎人";
            //            break;
            //        case E_Occupation.Master:
            //            atk += 200;
            //            def += 10;
            //            skill = "奥术冲击";
            //            occupation = "法师";
            //            break;
            //        default:
            //            break;
            //    }

            //    Console.WriteLine("你选了\"{0}{1}\",攻击力：{2},防御力{3},职业技能：{4}", sexStr, occupation, atk, def, skill);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 数组练习 1
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("倒序输出");
            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    int temp = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region 数组练习 2
            //int[] array = new int[10];
            //try
            //{
            //    int min = 0;
            //    int max = 0;
            //    int sum = 0;
            //    int avg = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine("请输入第{0}位同学的成绩", i + 1);
            //        array[i] = int.Parse(Console.ReadLine());
            //        //第一次进来 min max 没有任何意义 所以第一次可以就认为该成绩即使 最高分也是最低分
            //        if (i == 0)
            //        {
            //            min = array[i];
            //            max = array[i];
            //        }
            //        else
            //        {
            //            //只有 除了第一次以外  才来进行 大小值的判断 
            //            if (min > array[i])
            //            {
            //                min = array[i];
            //            }
            //            if (max < array[i])
            //            {
            //                max = array[i];
            //            }
            //        }
            //        sum += array[i];
            //    }
            //    avg = sum / array.Length;

            //    Console.WriteLine("最高分{0}最低分{1}平均分{2}", max, min, avg);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion
            #region 数组练习 3
            //string[] strs = new string[25];
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    strs[i] = i % 2 == 0 ? "■" : "□";
            //    //if( i % 2 == 0 )
            //    //{
            //    //    strs[i] = "■";
            //    //}
            //    //else
            //    //{
            //    //    strs[i] = "□";
            //    //}
            //}

            //for(int i=0;i<strs.Length;++i)
            //{
            //    if(i% 5 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(strs[i]+" ");
            //}
            #endregion

            #region 二维数组练习 4
            //将1到10000赋值给一个二维数组（100行100列） 
            //int[,] array = new int[100, 100];
            //int index = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = index;
            //        ++index;
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
            //int[,] array = new int[4, 4];
            //Random r = new Random();
            //for(int i=0;i<array.GetLength(0);++i)
            //{
            //    for(int j=0;j<array.GetLength(1); ++j)
            //    {
            //        if (i <= 1 && j > 1)
            //        {
            //            array[i, j] = 0;
            //        }
            //        else
            //        {
            //            array[i, j] = r.Next(1, 101);
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            //int[,] array = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 11);
            //        //对角线 元素 满足的条件
            //        if (i == j || i + j == 2)
            //        {
            //            sum += array[i, j];
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);

            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //int[,] array = new int[5, 5];
            //Random r = new Random();
            ////就是记录 最大值的 行列号
            //int maxI = 0;
            //int maxJ = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 501);
            //        Console.Write(array[i, j] + " ");
            //        //找最大值
            //        if (array[maxI, maxJ] < array[i, j])
            //        {
            //            maxI = i;
            //            maxJ = j;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("最大值为{0}，行{1}列{2}", array[maxI, maxJ], maxI, maxJ);

            //int[,] array = new int[5, 5] { { 0,0,0,0,0},
            //                               { 0,0,0,0,0},
            //                               { 0,0,1,1,0},
            //                               { 0,0,0,0,0},
            //                               { 0,0,0,0,0}};
            //bool[] hang = new bool[5];
            //bool[] lie = new bool[5];
            //for(int i=0;i<array.GetLength(0);++i)
            //{
            //    for(int j=0;j<array.GetLength(1); ++j)
            //    {
            //        if (array[i, j] == 1)
            //        {
            //            hang[i] = true;
            //            lie[j] = true;
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------------");
            //for(int i=0;i<array.GetLength(0);i++)
            //{
            //    for(int j=0;j<array.GetLength(1);++j)
            //    {
            //        if (hang[i] || lie[j])
            //        {
            //            array[i, j] = 1;
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}

