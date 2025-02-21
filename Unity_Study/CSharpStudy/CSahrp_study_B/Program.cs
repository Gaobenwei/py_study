//namespace CSahrp_study_B
//{
//    #region enum
//    //1.namespace语句块中（常用）
//    //2.class语句块中 struct语句块中
//    //注意：枚举不能在函数语句块中申明！！
//    enum E_MonsterType
//    {
//        Normal,//0
//        Boss,//1
//    }
//    enum E_PlayerType
//    {
//        Main,
//        Other,
//    }
//    #endregion
//    internal class Program
//    {
//        #region 函数
//        //函数的定义 在 class hozhe struct语句块中
//        static void SayHello()
//        {
//            Console.WriteLine("Hello");
//            return;
//        }

//        static void SayName(string args)
//        {
//            Console.WriteLine("Hello" + args);
//            return;
//        }

//        //有参有多返回值的函数
//        static int[] Calc(int a,int b)
//        {
//            int sum = a + b;
//            int avg = sum / 2;
//            return new int[] { sum, avg };
//        }
//        #endregion

//        #region ref out
//        //ref out 用于函数参数传递,类似达到C++当中引用传递的效果
//        static void change(ref int value)
//        {
//            value = 999;
//        }

//        static void changearray(ref int[] value)
//        {
//            value = new int[] { 100, 122, 133 };
//        }

//        static void changeout(out int value)
//        {
//            value = 99;
//        }

//        static void changeoutarray(out int[] value)
//        {
//            value = new int[] { 1000, 1022, 1303 };
//        }

//        //ref 和 out 的区别：
//        //ref 要求在调用函数之前必须对变量进行初始化，内部可改可不改
//        //out 要求在函数内部必须对变量进行赋值，但必须在内部修改
//        #endregion

//        #region 变长参数
//        //1.变长参数 params关键字后面的类型必须是数组类型，数组类型可以是任意类型
//        // 2.变长参数必须是函数的最后一个参数,且只能有一个
//        static int Sum(params int[] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum += arr[i];
//            }
//            return sum;
//        }

//        static void PrintInfo(string name, int a,int b,params int[] arr)
//        {
//            Console.WriteLine(name);
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//            Console.WriteLine("**********************");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                Console.WriteLine(arr[i]);
//            }
//        }
//        //默认值的参数必须在参数列表的最后
//        static void Speak(string str ="我是你爹")
//        {
//            Console.WriteLine(str);
//            str = "woshinidie ";
//        }

//        #endregion

//        #region 函数重载
//        //其他和C++一样，注意ref和out修饰参数可以达到函数重载的效果，但是ref和out 这两者无法不一样函数签名
//        static void fun1(ref int a,int b)
//        { }
//        static void fun1(int a, int b) { }
//        //static void fun1(out int a, int b) { } //错,已经有ref的了
//        static void Speak(ref string str)
//        {
//            str = "woshinidie ";
//            return;
//        }

//        static void fun1(int a, int b, params int[] arr) { }
//        static void fun1(int a, params int[] arr) { }

//        static int GetMax(params int[] arr)
//        {
//            int max = arr[0];
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (max < arr[i])
//                {
//                    max = arr[i];
//                }
//            }
//            return max;
//        }

//        static float GetMax(params float[] arr)
//        {
//            float max = arr[0];
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (max < arr[i])
//                {
//                    max = arr[i];
//                }
//            }
//            return max;
//        }

//        static double GetMax(params double[] arr)
//        {
//            double max = arr[0];
//            for (int i = 1; i < arr.Length; i++)
//            {
//                if (max < arr[i])
//                {
//                    max = arr[i];
//                }
//            }
//            return max;
//        }

//        static int fun11(int n)
//        {
//            if(n ==1)
//            {
//                return 1;
//            }
//            return n*fun11(n - 1);
//        }

//        static int func22(int n)
//        {
//            if ( n==1)
//            {
//                return 1;
//            }
//            return fun11(n) + func22(n - 1);
//        }

//        static void func33(double n, int day=0 )
//        {
//            if(day==10)
//            {
//                Console.WriteLine("第{0}天剩下{1}长的柱子", day, n);
//                return;
//            }
//            ++day;
//            n /= 2;
//            func33(n, day);
//        }

//        static bool func111(int n)
//        {
//            Console.Write(n+ " ");
//            return n == 200 || func111(n + 1); //递归完成循环的作用，条件判断短路 达到递归终止的效果
//        }
//        #endregion

//        static void Main(string[] args)
//        {
//            func33(100, 0);

//            Console.WriteLine(func22(3));
//            Console.WriteLine(GetMax(1, 2, 3));
//            Console.WriteLine(GetMax(1.1f, 2.2f, 3.3f));
//            Console.WriteLine(GetMax(1.1, 2.2, 3.3,4.4,5.5));

//            string str1 = "我是你爹";
//            Speak(ref str1);
//            Console.WriteLine(str1);

//            CSahrp_study_B.Program.SayHello();
//            SayName("你爹");
//            int a = 1;
//            int b;
//            Console.WriteLine(a);
//            change(ref a);
//            Console.WriteLine(a);
//            changeout(out a);
//            Console.WriteLine(a);
//            //change(ref b); //错
//            changeout(out b);
//            Console.WriteLine(b);

//            Console.WriteLine("**********************");
//            int[] arr = { 1, 2, 3 };
//            Console.WriteLine(arr[0]);
//            changearray(ref arr);
//            Console.WriteLine(arr[0]);
//            changeoutarray(out arr);
//            Console.WriteLine(arr[0]);
//            int[] arr2;
//            //changearray(ref arr2); //错
//            changeoutarray(out arr2);

//            Console.WriteLine(Sum(1,2,3,5,5,47,47,8,8,8,8,8,8,8,8));
//            PrintInfo("你爹", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

//            //#region enum 使用 类型转换
//            //Console.WriteLine("枚举");
//            //E_PlayerType playerType = E_PlayerType.Other;
//            //if (playerType == E_PlayerType.Main)
//            //{
//            //    Console.WriteLine("主玩家逻辑");
//            //}
//            //else if (playerType == E_PlayerType.Other)
//            //{
//            //    Console.WriteLine("其它玩家逻辑");
//            //}
//            ////枚举和switch是天生一对
//            //E_MonsterType monsterType = E_MonsterType.Boss;
//            //switch (monsterType)
//            //{
//            //    case E_MonsterType.Normal:
//            //    //Console.WriteLine("普通怪物逻辑");
//            //    //break;
//            //    case E_MonsterType.Boss:
//            //        Console.WriteLine("Boss逻辑");
//            //        break;
//            //    default:
//            //        break;
//            //}

//            //// 1.枚举和int互转
//            //int i = (int)playerType;
//            //Console.WriteLine(i);
//            ////int 转枚举
//            //playerType = 0;

//            //// 2.枚举和string相互转换
//            //string str = playerType.ToString();
//            //Console.WriteLine("12121212");
//            //Console.WriteLine(str);

//            ////把string转成枚举呢
//            ////Parse后 第一个参数 ：你要转为的是哪个 枚举类型 第二个参数：用于转换的对应枚举项的字符串
//            ////转换完毕后 是一个通用的类型 我们需要用括号强转成我们想要的目标枚举类型
//            //playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "other");
//            //Console.WriteLine(playerType);
//            //#endregion

//            #region 数组
//            //int[] arr5 = new int[5];
//            //int[] arr1;
//            //int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
//            //int[] arr4 = new int[] { 1, 2, 3, 4, 5 };
//            //int[] array = { 1, 2, 3, 4, 5 };

//            //Console.WriteLine(array.Length);
//            //Console.WriteLine(array[0]);
//            //Console.WriteLine(array[2]);
//            //Console.WriteLine(array[4]);
//            //array[0] = 99;
//            //Console.WriteLine(array[0]);
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    Console.WriteLine(array[i]);
//            //}
//            //// 数组初始化以后 是不能够 直接添加新的元素的
//            //Console.WriteLine("**********************");
//            //int[] array2 = new int[6];
//            ////搬家
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    array2[i] = array[i];
//            //}
//            //array = array2;
//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    Console.WriteLine(array[i]);
//            //}
//            //array[5] = 999;
//            //Console.WriteLine("**********************");
//            //// 数组初始化以后 是不能够 直接删除元素的
//            //int[] array3 = new int[5];
//            ////搬家
//            //for (int i = 0; i < array3.Length; i++)
//            //{
//            //    array3[i] = array[i];
//            //}
//            //array = array3;
//            //Console.WriteLine(array.Length);

//            //int a = 3;

//            //for (int i = 0; i < array.Length; i++)
//            //{
//            //    if (a == array[i])
//            //    {
//            //        Console.WriteLine("和a相等的元素在{0}索引位置", i);
//            //        break;
//            //    }
//            //}
//            #endregion

//            #region 二维数组
//            //int[,] arr = new int[2, 3];
//            //int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

//            //int[,] arr3 = new int[,] { { 1, 2, 3 },
//            //                        { 4, 5, 6 } };
//            //int[,] arr4 = { { 1, 2, 3 },
//            //                { 4, 5, 6 } };
//            //Console.WriteLine(arr3[0, 1]);
//            //Console.WriteLine(arr4[1, 2]);
//            //Console.Write("行：{0}，列：{1}", arr4.GetLength(0), arr4.GetLength(1));
//            //arr4[1, 2] = 999;
//            //Console.WriteLine(arr4[1, 2]);
//            //Console.WriteLine("**********************");
//            //for (int i = 0; i < arr4.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < arr4.GetLength(1); j++)
//            //    {
//            //        //i 行 0 1
//            //        //j 列 0 1 2
//            //        Console.WriteLine(arr4[i, j]);
//            //        //0,0  0,1  0,2
//            //        //1,0  1,1  1,2
//            //    }
//            //}

//            ////5.增加数组的元素
//            //// 数组 声明初始化过后 就不能再原有的基础上进行 添加 或者删除了
//            //int[,] array2 = new int[3, 3];
//            //for (int i = 0; i < arr4.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < arr4.GetLength(1); j++)
//            //    {
//            //        array2[i, j] = arr4[i, j];
//            //    }
//            //}
//            //arr4 = array2;
//            //arr4[2,0] = 7;
//            //arr4[2, 1] = 8;
//            ////arr4[2, 2] = 9;
//            //Console.WriteLine("**********");
//            //for (int i = 0; i < arr4.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < arr4.GetLength(1); j++)
//            //    {
//            //        //i 行 0 1
//            //        //j 列 0 1 2
//            //        Console.WriteLine(arr4[i, j]);
//            //        //0,0  0,1  0,2
//            //        //1,0  1,1  1,2
//            //    }
//            //}
//            #endregion

//            #region 交错数组[][]
//            //int[][] arr1 = new int[3][];
//            //int[][] arr2 = new int[3][] {
//            //    new int[]{1,2},
//            //    new int[]{3,4,5},
//            //    new int[]{6,7,8,9}
//            //};
//            //int[][] arr4 = new int[][] {
//            //    new int[]{1,2},
//            //    new int[]{3,4,5},
//            //    new int[]{6,7,8,9}
//            //};
//            //int[][] arr5 = {
//            //    new int[]{1,2},
//            //    new int[]{3,4,5},
//            //    new int[]{6,7,8,9}
//            //};
//            //Console.WriteLine(arr5.GetLength(0));
//            //Console.WriteLine(arr5[2].GetLength(0));
//            //Console.WriteLine(arr5[2][3]);
//            //arr5[2][3] = 999;
//            //Console.WriteLine(arr5[2][3]);
//            //for(int i=0;i<arr5.GetLength(0);++i)
//            //{
//            //    for(int j = 0; j < arr5[i].GetLength(0);++j)
//            //    {
//            //        Console.Write(arr5[i][j]+" ");
//            //    }
//            //    Console.WriteLine("");
//            //}
//            #endregion

//            #region 值和引用类型
//            //引用类型 ：string 数组 类
//            //值类型 int float double char bool enum struct等
//            //值类型存储在栈内存中，系统分配，自动回收
//            //引用类型存储在堆内存中， 需要手动分配和释放,在栈内存中存储的是引用的地址
//            //类似C++的值和引用，值有各自的内存空间，引用指向同一块内存空间

//            //int a = 10;
//            //int[] arr1 = { 1, 2, 3 };
//            //int[] arr2 = arr1;
//            //int b = a;
//            //Console.WriteLine("a={0},b={1}", a, b);
//            //Console.WriteLine("arr1[0]={0},arr2[0]={1}", arr1[0], arr2[0]);
//            //b = 20;
//            //arr2[0] = 9899;
//            //Console.WriteLine("修改后的：");
//            //Console.WriteLine("a={0},b={1}", a, b);
//            //Console.WriteLine("arr1[0]={0},arr2[0]={1}", arr1[0], arr2[0]);

//            //string str1 = "hello";
//            //string str2 = str1;
//            //str2 = "world";
//            //Console.WriteLine("str1={0},str2={1}", str1, str2);

//            #endregion


//        }
//    }
//}

namespace Lession_Struct
{
    #region struct
    //结构体 一把写在namespace语句块中
    struct Student
    {
        public int age;
        public bool sex;
        public int number;
        public string name;
        public void Speak() //目前 不用加static
        {
            Console.WriteLine("我是{0}，今年{1}岁", name, age);
        }
        public Student(int age,bool sex,int number,string name) //C#构造函数必须有参数好像
        {
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }
        public Student(int age) //构造函数可以重载，但是最好把所有属性都初始化
        {
            this.age = age;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Student stu;
            stu.age = 18;
            stu.name = "你爹";
            stu.number = 1001;
            stu.sex = true;
            stu.Speak();

            Student stuw=new Student(19, false, 1002, "你爹2");
            stuw.Speak();
            Student stuw2 = new Student(20);
            stuw2.Speak();
        }
    }
}