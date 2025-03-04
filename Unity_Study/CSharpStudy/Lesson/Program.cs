// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics;
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

//namespace Lesson_B_1
//{

//    enum E_QQType
//    {
//        /// <summary>
//        /// QQ状态
//        /// </summary>
//        OnLine,
//        Leave,
//        Busy,
//        Invisible,
//    }

//    enum E_CafeType
//    {
//        /// <summary>
//        /// 中杯
//        /// </summary>
//        M,
//        /// <summary>
//        /// 大杯
//        /// </summary>
//        B,
//        /// <summary>
//        /// 超大杯
//        /// </summary>
//        S,
//    }

//    enum E_Sex
//    {
//        Man,
//        Woman,
//    }
//    enum E_Occupation
//    {
//        /// <summary>
//        /// 战士
//        /// </summary>
//        Warrior,
//        /// <summary>
//        /// 猎人
//        /// </summary>
//        Hunter,
//        /// <summary>
//        /// 法师
//        /// </summary>
//        Master,
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("枚举，练习");
//            #region enum 练习1
//            //定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
//            //try
//            //{
//            //    Console.WriteLine("请输入QQ的状态(0在线，1离开，2忙，3隐身)");
//            //    int type = int.Parse(Console.ReadLine());
//            //    E_QQType qqType = (E_QQType)type;
//            //    Console.WriteLine(qqType);
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("请输入数字");
//            //}
//            #endregion

//            #region enum 练习2
//            //try
//            //{
//            //    Console.WriteLine("请输入咖啡杯型(0中杯，1大杯，2超大杯)");
//            //    int cafeType = int.Parse(Console.ReadLine());
//            //    E_CafeType cType = (E_CafeType)cafeType;
//            //    switch(cType)
//            //    {
//            //        case E_CafeType.M:
//            //            Console.WriteLine("中杯");
//            //            break;
//            //        case E_CafeType.B:
//            //            Console.WriteLine("大杯");
//            //            break;
//            //        case E_CafeType.S:
//            //            Console.WriteLine("超大杯");
//            //            break;
//            //        default:
//            //            Console.WriteLine("输入正确类型");
//            //            break;
//            //    }
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("请输入数字");
//            //}
//            #endregion

//            #region enum 练习3
//            //try
//            //{
//            //    Console.WriteLine("请选择性别（男0 女1）");
//            //    E_Sex sex = (E_Sex)int.Parse(Console.ReadLine());
//            //    string sexStr = "";
//            //    int atk = 0;
//            //    int def = 0;
//            //    switch (sex)
//            //    {
//            //        case E_Sex.Man:
//            //            sexStr = "男性";
//            //            atk += 50;
//            //            def += 100;
//            //            break;
//            //        case E_Sex.Woman:
//            //            sexStr = "女性";
//            //            atk += 150;
//            //            def += 20;
//            //            break;
//            //    }
//            //    Console.WriteLine("请选择职业（战士0 猎人1 法师2）");
//            //    E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
//            //    string skill = "";
//            //    string occupation = "";
//            //    switch (o)
//            //    {
//            //        case E_Occupation.Warrior:
//            //            atk += 20;
//            //            def += 100;
//            //            skill = "冲锋";
//            //            occupation = "战士";
//            //            break;
//            //        case E_Occupation.Hunter:
//            //            atk += 120;
//            //            def += 30;
//            //            skill = "假死";
//            //            occupation = "猎人";
//            //            break;
//            //        case E_Occupation.Master:
//            //            atk += 200;
//            //            def += 10;
//            //            skill = "奥术冲击";
//            //            occupation = "法师";
//            //            break;
//            //        default:
//            //            break;
//            //    }

//            //    Console.WriteLine("你选了\"{0}{1}\",攻击力：{2},防御力{3},职业技能：{4}", sexStr, occupation, atk, def, skill);
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("请输入数字");
//            //}
//            #endregion

//            #region 数组练习 1
//            //int[] array = new int[10];
//            //Random r = new Random();
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    array[i] = r.Next(0, 101);
//            //    Console.WriteLine(array[i]);
//            //}
//            //Console.WriteLine("倒序输出");
//            //for (int i = 0; i < array.Length / 2; i++)
//            //{
//            //    int temp = array[i];
//            //    array[i] = array[array.Length - 1 - i];
//            //    array[array.Length - 1 - i] = temp;
//            //}
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    Console.WriteLine(array[i]);
//            //}
//            #endregion
//            #region 数组练习 2
//            //int[] array = new int[10];
//            //try
//            //{
//            //    int min = 0;
//            //    int max = 0;
//            //    int sum = 0;
//            //    int avg = 0;
//            //    for (int i = 0; i < array.Length; i++)
//            //    {
//            //        Console.WriteLine("请输入第{0}位同学的成绩", i + 1);
//            //        array[i] = int.Parse(Console.ReadLine());
//            //        //第一次进来 min max 没有任何意义 所以第一次可以就认为该成绩即使 最高分也是最低分
//            //        if (i == 0)
//            //        {
//            //            min = array[i];
//            //            max = array[i];
//            //        }
//            //        else
//            //        {
//            //            //只有 除了第一次以外  才来进行 大小值的判断 
//            //            if (min > array[i])
//            //            {
//            //                min = array[i];
//            //            }
//            //            if (max < array[i])
//            //            {
//            //                max = array[i];
//            //            }
//            //        }
//            //        sum += array[i];
//            //    }
//            //    avg = sum / array.Length;

//            //    Console.WriteLine("最高分{0}最低分{1}平均分{2}", max, min, avg);
//            //}
//            //catch
//            //{
//            //    Console.WriteLine("请输入数字");
//            //}
//            #endregion
//            #region 数组练习 3
//            //string[] strs = new string[25];
//            //for (int i = 0; i < strs.Length; i++)
//            //{
//            //    strs[i] = i % 2 == 0 ? "■" : "□";
//            //    //if( i % 2 == 0 )
//            //    //{
//            //    //    strs[i] = "■";
//            //    //}
//            //    //else
//            //    //{
//            //    //    strs[i] = "□";
//            //    //}
//            //}

//            //for(int i=0;i<strs.Length;++i)
//            //{
//            //    if(i% 5 == 0)
//            //    {
//            //        Console.WriteLine();
//            //    }
//            //    Console.Write(strs[i]+" ");
//            //}
//            #endregion

//            #region 二维数组练习 4
//            //将1到10000赋值给一个二维数组（100行100列） 
//            //int[,] array = new int[100, 100];
//            //int index = 1;
//            //for (int i = 0; i < array.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < array.GetLength(1); j++)
//            //    {
//            //        array[i, j] = index;
//            //        ++index;
//            //        Console.Write(array[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
//            //int[,] array = new int[4, 4];
//            //Random r = new Random();
//            //for(int i=0;i<array.GetLength(0);++i)
//            //{
//            //    for(int j=0;j<array.GetLength(1); ++j)
//            //    {
//            //        if (i <= 1 && j > 1)
//            //        {
//            //            array[i, j] = 0;
//            //        }
//            //        else
//            //        {
//            //            array[i, j] = r.Next(1, 101);
//            //        }
//            //        Console.Write(array[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）
//            //int[,] array = new int[3, 3];
//            //Random r = new Random();
//            //int sum = 0;
//            //for (int i = 0; i < array.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < array.GetLength(1); j++)
//            //    {
//            //        array[i, j] = r.Next(1, 11);
//            //        //对角线 元素 满足的条件
//            //        if (i == j || i + j == 2)
//            //        {
//            //            sum += array[i, j];
//            //        }
//            //        Console.Write(array[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine(sum);

//            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
//            //int[,] array = new int[5, 5];
//            //Random r = new Random();
//            ////就是记录 最大值的 行列号
//            //int maxI = 0;
//            //int maxJ = 0;
//            //for (int i = 0; i < array.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < array.GetLength(1); j++)
//            //    {
//            //        array[i, j] = r.Next(1, 501);
//            //        Console.Write(array[i, j] + " ");
//            //        //找最大值
//            //        if (array[maxI, maxJ] < array[i, j])
//            //        {
//            //            maxI = i;
//            //            maxJ = j;
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}

//            //Console.WriteLine("最大值为{0}，行{1}列{2}", array[maxI, maxJ], maxI, maxJ);

//            //int[,] array = new int[5, 5] { { 0,0,0,0,0},
//            //                               { 0,0,0,0,0},
//            //                               { 0,0,1,1,0},
//            //                               { 0,0,0,0,0},
//            //                               { 0,0,0,0,0}};
//            //bool[] hang = new bool[5];
//            //bool[] lie = new bool[5];
//            //for(int i=0;i<array.GetLength(0);++i)
//            //{
//            //    for(int j=0;j<array.GetLength(1); ++j)
//            //    {
//            //        if (array[i, j] == 1)
//            //        {
//            //            hang[i] = true;
//            //            lie[j] = true;
//            //        }
//            //        Console.Write(array[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //Console.WriteLine("------------------");
//            //for(int i=0;i<array.GetLength(0);i++)
//            //{
//            //    for(int j=0;j<array.GetLength(1);++j)
//            //    {
//            //        if (hang[i] || lie[j])
//            //        {
//            //            array[i, j] = 1;
//            //        }
//            //        Console.Write(array[i, j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            #endregion
//        }
//    }
//}

//namespace Struct_1
//{
//    struct Rect
//    {
//        public float w;
//        public float h;
//        public float area;
//        public float perimeter;

//        public Rect(float w,float h)
//        {
//            this.w = w;
//            this.h = h;
//            this.area = w * h;
//            this.perimeter = 2 * (w + h);
//        }
//        public void writeinfo()
//        {
//            Console.WriteLine("宽{0}高{1}面积{2}周长{3}", w, h, area, perimeter);
//        }
//    }

//    struct OutMan
//    {
//        public string name;
//        public int atk;
//        public int def;
//        public int hp;
//        public OutMan(string name, int atk, int def, int hp)
//        {
//            this.name = name;
//            this.atk = atk;
//            this.def = def;
//            this.hp = hp;
//        }
//        public void Atk(ref Struct_1.Boss monster)
//        {
//            monster.hp-=atk - monster.def;
//        }
//    }

//    struct Boss
//    {
//        public string name;
//        public int atk;
//        public int def;
//        public int hp;

//        public Boss(string name, int atk, int def, int hp)
//        {
//            this.name = name;
//            this.atk = atk;
//            this.def = def;
//            this.hp = hp;
//        }
//        public void Atk(ref OutMan outman)
//        {
//            outman.hp-=this.atk - outman.def;
//        }
//    }


//    class Program
//    {
//        static int[] Sort_(int[] array, bool isAscend)
//        {
//            bool isSort = false;
//            for (int i = 1; i <= array.Length; ++i)
//            {
//                isSort = false;
//                for (int j = 0; j < array.Length - i; ++j)
//                {
//                    bool ordereed = isAscend ? array[j] > array[j + 1] : array[j] < array[j + 1];
//                    if (ordereed)
//                    {
//                        int temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;
//                        isSort = true;
//                    }
//                }
//                if (!isSort)
//                {
//                    break;
//                }
//            }
//            return array;
//        }
//        static void Main(string[] args)
//        {
//            Rect rect= new Rect(10,20); 
//            rect.writeinfo();
//            Rect[] rects = new Rect[10];
//            for(int i=0;i<10;++i)
//            {
//                rects[i] = new Rect(i, i + 5);
//                rects[i].writeinfo();
//            }
//            int[] array = new int[20];
//            Random r=new Random();
//            for(int i = 0; i < array.Length; ++i)
//            {
//                array[i] = r.Next(0, 101);
//                Console.Write(array[i] + " ");
//            }
//            //冒泡排序
//            bool isSort = false;
//            for (int i=1;i<=array.Length;++i)
//            {
//                isSort = false;
//                for(int j=0;j<array.Length-i;++j)
//                {
//                    if (array[j] < array[j + 1])
//                    {
//                        int temp = array[j];
//                        array[j] = array[j + 1];
//                        array[j + 1] = temp;
//                        isSort = true;
//                    }
//                }
//                if(!isSort)
//                {
//                    break;
//                }
//            }

//            Console.WriteLine();
//            for (int i = 0; i < array.Length; ++i)
//            {
//                Console.Write(array[i] + " ");
//            }
//            Console.WriteLine(":*-*-*-*-:");
//            int[] array2 = new int[] { 1,2,6,9,3,4,5,7,2,2,5,8,55,2,58,8};
//            //Sort_(array2, true);
//            Sort_(array2, false);
//            for (int i = 0; i < array2.Length; ++i)
//            {
//                Console.Write(array2[i] + " ");
//            }
//            Console.WriteLine("*------------*");
//            #region 选择排序 1 中间变量 记录最小值的下标，每轮开始，默认最小值的下标为当前轮的第一个元素下标
//            //for (int m=0;m<array2.Length-1;++m)
//            //{
//            //    int index_ = m;
//            //    for(int n=m+1;n<array2.Length;++n)
//            //    {
//            //        if (array2[index_] > array2[n])
//            //        {
//            //            index_ = n;
//            //        }
//            //    }
//            //    if(index_!=m)
//            //    {
//            //        int temp = array2[m];
//            //        array2[m] = array2[index_];
//            //        array2[index_] = temp;
//            //    }    
//            //}

//            //for (int i = 0; i < array2.Length; ++i)
//            //{
//            //    Console.Write(array2[i] + " ");
//            //}

//            int[] array_xuanze = new int[20];
//            Random r_xuanze =new Random();
//            for (int i=0;i<20;++i)
//            {
//                array_xuanze[i] = r_xuanze.Next(0, 101);
//            }
//            for (int i = 0; i < array_xuanze.Length; ++i)
//            {
//                Console.Write(array_xuanze[i] + " ");
//            }
//            Console.WriteLine("\n升序选择");

//            for (int m=0;m<array_xuanze.Length;++m)
//            {
//                int index_ = 0;
//                for(int n=1;n<array_xuanze.Length-m;++n)
//                {
//                    if (array_xuanze[index_]< array_xuanze[n])
//                    {
//                        index_ = n;
//                    }
//                }
//                if (index_ != array_xuanze.Length - 1 - m)
//                {
//                    int temp = array_xuanze[index_];
//                    array_xuanze[index_] = array_xuanze[array_xuanze.Length - 1 - m];
//                    array_xuanze[array_xuanze.Length - 1 - m] = temp; 
//                }
//            }
//            for (int i = 0; i < array_xuanze.Length; ++i)
//            {
//                Console.Write(array_xuanze[i] + " ");
//            }
//            Console.WriteLine("\n降序选择");
//            for (int m = 0; m < array_xuanze.Length; ++m)
//            {
//                int index_ = 0;
//                for (int n = 1; n < array_xuanze.Length - m; ++n)
//                {
//                    if (array_xuanze[index_] > array_xuanze[n])
//                    {
//                        index_ = n;
//                    }
//                }
//                if (index_ != array_xuanze.Length - 1 - m)
//                {
//                    int temp = array_xuanze[index_];
//                    array_xuanze[index_] = array_xuanze[array_xuanze.Length - 1 - m];
//                    array_xuanze[array_xuanze.Length - 1 - m] = temp;
//                }
//            }

//            for (int i = 0; i < array_xuanze.Length; ++i)
//            {
//                Console.Write(array_xuanze[i] + " ");
//            }
//            #endregion

//        }
//    }
//}


//namespace Lesson_suoyingqi //索引器
//{
//    class IntArray
//    {
//        private int[] array;
//        private int capacity;
//        private int lenngth;
//        public IntArray()
//        {
//            capacity = 5;
//            lenngth = 0;
//            array = new int[capacity];
//        }
//        // +
//        public void Add(int value)
//        {
//            //如果要增加就涉及扩容
//            //扩容就涉及 "搬家"
//            if (lenngth < capacity)
//            {
//                array[lenngth++] = value;
//            }
//            else
//            {
//                capacity *= 2;
//                int[] temparray= new int[capacity];
//                for(int i=0;i< array.Length; ++i)
//                {
//                    temparray[i] = array[i];
//                }
//                array = temparray;
//                array[lenngth++] = value;
//            }
//        }
//        //-
//        public void Remove(int value)
//        {
//            //找到 传入值 在哪个位置
//            for(int i=0;i<lenngth;++i)
//            {
//                if (array[i]==value)
//                {
//                    this.RemoveAt(i);
//                    return;
//                }
//            }
//        }

//        public void RemoveAt(int index)
//        {
//            if(index <0 || index >=lenngth)
//            {
//                Console.WriteLine("传入的索引不合法的，结束");
//                return;
//            }
//            for(int i=index;i<lenngth - 1; ++i)
//            {
//                array[i] = array[i + 1];
//            }
//            --lenngth;
//        }
//        //查+改
//        public int this[int index]
//        {
//            get
//            {
//                if(index >= lenngth || index < 0)
//                {
//                    Console.WriteLine("索引不合法");
//                    return -1;
//                }
//                return array[index];
//            }
//            set
//            {
//                if(index >=lenngth || index<0)
//                {
//                    Console.WriteLine("索引不合法");
//                }
//                array[index]=value;
//            }
//        }

//        public int Length
//        {
//            get
//            {
//                return lenngth;
//            }

//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("索引器练习题");

//            IntArray array = new IntArray();
//            array.Add(100);
//            array.Add(200);
//            array.RemoveAt(1);
//            Console.WriteLine(array.Length);
//            array.Remove(200);
//            Console.WriteLine(array[1]);
//            Console.WriteLine(array.Length);
//        }
//    }
//}

//namespace Lesson7_练习题
//{
//    #region 练习题二
//    //请用静态成员相关知识实现
//    //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的存在，
//    //不能在外部实例化，直接通过该类类名就能够得到唯一的对象
//    class Test
//    {
//        private static Test t = new Test();
//        public int testInt = 100;
//        public static Test T //一般还是会在第一次访问的时候创建对象，调用 在普通的之前
//        {
//            get { return t; }
//            set { }
//        }

//        private Test()
//        {
//            Console.WriteLine("构造函数");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("静态成员练习题");

//            Console.WriteLine(Test.T.testInt);
//        }
//    }
//    #endregion
//}


//namespace Lesson8_练习题
//{
//    #region 练习题
//    //写一个用于数学计算的静态类
//    //该类中提供计算圆面积，圆周长，矩形面积，矩形周长，取一个数的绝对值 等方法
//    static class MathTool
//    {
//        public static float PI = 3.1415926f;
//        public static float CalcCircleArea(float r)
//        {
//            return PI * r * r;
//        }
//        public static float CalcCircleLength(float r)
//        {
//            return 2 * PI * r;
//        }
//        public static float CalcRectArea(float w, float h)
//        {
//            return w * h;
//        }
//        public static float CalcRectLength(float w, float h)
//        {
//            return 2 * w + 2 * h;
//        }
//        public static float GetABS(float value)
//        {
//            return value >= 0 ? value : -value;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");

//            Console.WriteLine(MathTool.GetABS(-7));
//            Console.WriteLine(MathTool.CalcRectLength(2, 3));
//        }
//    }
//    #endregion
//}

//namespace Lesson9_练习题
//{
//    #region 练习题一
//    //为整形拓展一个求平方的方法
//    static class Tools
//    {
//        public static int Square(this int value)
//        {
//            return value * value;
//        }
//        public static void KillSelf(this Player player)
//        {
//            Console.WriteLine("{0}自杀了", player.name);
//        }
//    }
//    #endregion
//    #region 练习题二
//    //写一个玩家类，包含姓名，血量，攻击力，防御力等特征，攻击，移动，受伤等方法
//    //为该玩家类拓展一个自杀的方法
//    class Player
//    {
//        public string name;
//        public int hp;
//        public int atk;
//        public int def;

//        public void Atk(Player otherPlayer)
//        {

//        }
//        public void Move()
//        {

//        }
//        public void Wound(Player otherPlayer)
//        {

//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("拓展方法练习题");

//            int i = 2;
//            Console.WriteLine(i.Square());

//            Player p = new Player();
//            p.name = "小红";
//            p.KillSelf();
//        }
//    }
//}

//namespace Lesson10_练习题
//{
//    #region 练习题一
//    struct Position
//    {
//        public int x;
//        public int y;
//        public Position(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//        public static bool operator==(Position p1, Position p2)
//        {
//            if(p1.x == p2.x && p1.y == p2.y)
//            {
//                return true;
//            }
//            return false;
//        }
//        public static bool operator !=(Position p1, Position p2)
//        {
//            return !(p1 == p2);
//        }

//    }

//    class Vector3
//    {
//        public int x;
//        public int y;
//        public int z;
//        public Vector3(int x, int y, int z)
//        {
//            this.x = x;
//            this.y = y;
//            this.z = z;
//        }
//        public static Vector3 operator+(Vector3 v1, Vector3 v2)
//        {
//            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
//        }
//        public static Vector3 operator -(Vector3 v1, Vector3 v2)
//        {
//            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
//        }
//        public static Vector3 operator *(Vector3 v1, int value)
//        {
//            return new Vector3(v1.x * value, v1.y * value, v1.z * value);
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Position position = new Position(1,2);
//            Position position2 = new Position(1, 2);
//            if (position == position2)
//            {
//                Console.WriteLine("相等");
//            }
//            else
//            {
//                Console.WriteLine("不相等");
//            }
//            Vector3 v1 = new Vector3(1, 2, 3);
//            Vector3 v2 = new Vector3(4, 5, 6);
//            Console.WriteLine((v1 + v2).x);
//        }
//    }
//}