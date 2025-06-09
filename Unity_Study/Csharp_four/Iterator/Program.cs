using System;
using System.Collections;
using System.Collections.Generic;

//namespace Iterator
//{
//    #region 知识点一 迭代器是什么
//    //迭代器（iterator）有时又称光标（cursor）
//    //是程序设计的软件设计模式
//    //迭代器模式提供一个方法顺序访问一个聚合对象中的各个元素
//    //而又不暴露其内部的标识

//    //在表现效果上看
//    //是可以在容器对象（例如链表或数组）上遍历访问的接口
//    //设计人员无需关心容器对象的内存分配的实现细节
//    //可以用foreach遍历的类，都是实现了迭代器的
//    #endregion

//    #region 知识点二 标准迭代器的实现方法
//    //关键接口：IEnumerator,IEnumerable
//    //命名空间：using System.Collections;
//    //可以通过同时继承IEnumerable和IEnumerator实现其中的方法

//    class CustomList : IEnumerable, IEnumerator
//    {
//        private int[] list;
//        //从-1开始的光标 用于表示 数据得到了哪个位置
//        private int position = -1;
//        public CustomList()
//        {
//            list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        }
//        #region IEnumerable
//        public IEnumerator GetEnumerator()
//        {
//            Reset();
//            return this;
//        }
//        #endregion

//        public object Current
//        {
//            get { return list[position]; }
//            set { list[position] = 0; }
//        }
//        public bool MoveNext()
//        {
//            //移动光标
//            ++position;
//            //是否溢出 溢出就不合法
//            return position < list.Length;
//        }
//        //reset是重置光标位置 一般写在获取 IEnumerator对象这个函数中
//        //用于第一次重置光标位置
//        public void Reset()
//        {
//            position = -1;
//        }
//    }

//    #endregion

//    #region 知识点三 用yield return 语法糖实现迭代器
//    //yield return 是C#提供给我们的语法糖
//    //所谓语法糖，也称糖衣语法
//    //主要作用就是将复杂逻辑简单化，可以增加程序的可读性
//    //从而减少程序代码出错的机会

//    //关键接口：IEnumerable
//    //命名空间：using System.Collections;
//    //让想要通过foreach遍历的自定义类实现接口中的方法GetEnumerator即可
//    class CustomList2:IEnumerable
//    {
//        private int[] list;

//        public CustomList2()
//        {
//            list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
//        }
//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 0; i < list.Length; ++i)
//            {
//                //yield关键字 配合迭代器使用
//                //可以理解为 暂时返回 保留当前的状态
//                //一会还会在回来
//                //C#的语法糖
//                yield return list[i];
//            }
//            //yield return list[0];
//            //yield return list[1];
//            //yield return list[2];
//            //yield return list[3];
//            //yield return list[4];
//            //yield return list[5];
//            //yield return list[6];
//            //yield return list[7];
//        }
//    }


//    #endregion

//    #region 知识点四 用yield return 语法糖为泛型类实现迭代器
//    class CustomList<T> : IEnumerable
//    {
//        private T[] array;

//        public CustomList(params T[] array)
//        {
//            this.array = array;
//        }

//        public IEnumerator GetEnumerator()
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                yield return array[i];
//            }
//        }
//    }
//    #endregion

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("iterator");
//            CustomList list = new CustomList();
//            //foreach本质 
//            //1.先获取in后面这个对象的 IEnumerator
//            //  会调用对象其中的GetEnumerator方法 来获取
//            //2.执行得到这个IEnumerator对象中的 MoveNext方法
//            //3.只要MoveNext方法的返回值时true 就会去得到Current
//            //  然后复制给 item

//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }

//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }

//            CustomList<string> list2 = new CustomList<string>("123", "321", "333", "555");
//            foreach (string item in list2)
//            {
//                Console.WriteLine(item);
//            }
//            foreach (string item in list2)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
//总结：
//迭代器就是可以让我们在外部直接通过foreach遍历对象中元素而不需要了解其结构
//主要的两种方式
//1.传统方式 继承两个接口 实现里面的方法
//2.用语法糖 yield return 去返回内容 只需要继承一个接口即可


//namespace Iterator_test
//{
//    #region 练习题
//    //请为一个自定义类
//    //用两种方法让其可以被foreach遍历
//    class CustomList : IEnumerable
//    {
//        private int[] list;

//        public CustomList()
//        {
//            list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        }

//        //public IEnumerator GetEnumerator()
//        //{
//        //    for (int i = 0; i < list.Length; i++)
//        //    {
//        //        yield return list[i];
//        //    }
//        //}

//        public IEnumerator GetEnumerator()
//        {
//            for(int i =0;i<list.Length;++i)
//            {
//                yield return list[i];
//            }
//        }
//    }

//    class CustomList2 : IEnumerable, IEnumerator
//    {
//        private string[] list;

//        private int position = -1;

//        public CustomList2()
//        {
//            list = new string[] { "123", "321", "666", "7777" };
//        }
//        public IEnumerator GetEnumerator()
//        {
//            Reset();
//            return this;
//        }
//        public void Reset()
//        {
//            position = -1;
//        }
//        public bool MoveNext()
//        {
//            ++position;
//            return position < list.Length;
//        }
//        public object Current
//        {
//            get { return list[position]; }
//        }
//    }
//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("迭代器练习题");

//            CustomList list = new CustomList();
//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }

//            CustomList2 list2 = new CustomList2();
//            foreach (string item in list2)
//            {
//                Console.WriteLine(item);
//            }
//            foreach (string item in list2)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

//namespace var_and_more
//{
//    class Person
//    {
//        private int money;
//        public bool sex;
//        private int age;
//        public int Age
//        {
//            get { return this.age; }
//            set { this.age = value; }
//        }
//        public string Name
//        {
//            get => "nidie";
//            set => sex = true;
//        }
//        public Person(int money)
//        {
//            this.money = money;
//        }
//        public int Add(int x, int y) => x + y;
//        public void Speak(string str) => Console.WriteLine(str);
//    }

//    class Program
//    {
//        static void Main(string[]args)
//        {
//            Console.WriteLine("特殊语法");
//            #region var
//            var i = 5;
//            var s = "123";
//            var array = new int[] { 1, 2, 3, 4 };
//            var list = new List<int>();
//            #endregion
//            #region {}初始化
//            Person p = new Person(100) { sex = true, Age = 18, Name = "123" };
//            Person p2 = new Person(200) { Age = 18 };
//            #endregion
//            #region 设置集合初值
//            //申明集合对象时
//            //也可以通过大括号 直接初始化内部属性
//            int[] array2 = new int[] { 1, 2, 3, 4, 5 };

//            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6 };

//            List<Person> listPerson = new List<Person>() {
//                new Person(200),
//                new Person(100){Age = 10},
//                new Person(1){sex = true, Name = "唐老狮"}
//            };
//            Dictionary<int, string> dic = new Dictionary<int, string>()
//            {
//                { 1, "123" },
//                { 2, "222"},
//            };
//            #endregion
//            #region 匿名类型
//            var v = new { age = 10, money = 11, name = "小明" };
//            Console.WriteLine(v.age);
//            Console.WriteLine(v.name);
//            Console.WriteLine(typeof(Person));
//            Console.WriteLine(p2.GetType());
//            Console.WriteLine(v.GetType());
//            #endregion
//            #region 可以为空的类型
//            int? c = null;
//            if (c.HasValue) { Console.WriteLine(c);Console.WriteLine(c.Value); }
//            int? value = null;
//            //  4-1.如果为空 默认返回值类型的默认值
//            Console.WriteLine(value.GetValueOrDefault());
//            //  4-2.也可以指定一个默认值
//            Console.WriteLine(value.GetValueOrDefault(100));
//            float? f = null;
//            double? d = null;
//            object? o = "null";
//            if (o != null)
//            {
//                Console.WriteLine(o.ToString());
//            }
//            Console.WriteLine(o?.ToString());
//            int[] arrayInt = null;
//            Console.WriteLine(arrayInt?.Length);
//            Action action = null;
//            action?.Invoke();
//            #endregion
//            #region 空合并操作符
//            // 空合并操作符 ??
//            // 左边值 ?? 右边值
//            // 如果左边值为null 就返回右边值 否则返回左边值
//            // 只要是可以为null的类型都能用
//            int? intV = null;
//            //int intI = intV == null ? 100 : intV.Value;
//            int intI = intV ?? 100;
//            Console.WriteLine(intI);

//            string str = null;
//            str = str ?? "hahah";
//            Console.WriteLine(str);
//            #endregion
//            #region 内插字符串 &
//            string name = "唐老狮";
//            int age = 18;
//            Console.WriteLine($"好好秀恶,{name},年级{age}");
//            #endregion


//        }
//    }
//}

using System;
using System.Collections.Generic;

//namespace Lesson24_值和引用
//{
//    class Test
//    {
//        public static int TestI = 0;

//        int b = 0;

//        string str = "123";

//        TestStrict ts = new TestStrict();
//        public void Fun()
//        {
//            b = 1;
//        }
//    }

//    struct TestStrict
//    {
//        public Test t;
//        public int i;
//    }

//    class Program
//    {
//        static int b;
//        static void Main(string[] args)
//        {
//            Console.WriteLine("值和引用");
//            #region 知识回顾
//            //值类型
//            //无符号:byte,ushort,uint,ulong
//            //有符号:sbyte,short,int,long
//            //浮点数:float,double,decimal
//            //特殊:char,bool
//            //枚举:enum
//            //结构体:struct

//            //引用类型
//            //string
//            //数组
//            //class
//            //interface
//            //委托

//            //值类型和引用类型的本质区别
//            //值的具体内容存在栈内存上
//            //引用的具体内容存在堆内存上
//            #endregion

//            #region 问题一 如何判断 值类型和引用类型
//            //F12进到类型的内部去查看
//            //是class就是引用
//            //是struct就是值
//            int i = 12;
//            string str = "123";
//            #endregion

//            #region 问题二 语句块
//            //命名空间
//            //   ↓
//            //类、接口、结构体
//            //   ↓
//            //函数、属性、索引器、运算符重载等（类、接口、结构体）
//            //   ↓
//            //条件分支、循环

//            //上层语句块：类、结构体
//            //中层语句块：函数
//            //底层的语句块： 条件分支 循环等

//            //我们的逻辑代码写在哪里？
//            //函数、条件分支、循环-中底层语句块中

//            //我们的变量可以申明在哪里？
//            //上、中、底都能申明变量
//            //上层语句块中：成员变量
//            //中、底层语句块中：临时变量
//            #endregion

//            #region 问题三 变量的生命周期
//            //编程时大部分都是 临时变量
//            //在中底层申明的临时变量（函数、条件分支、循环语句块等）
//            //语句块执行结束 
//            //没有被记录的对象将被回收或变成垃圾
//            //值类型：被系统自动回收
//            //引用类型：栈上用于存地址的房间被系统自动回收，堆中具体内容变成垃圾，待下次GC回收

//            int i2 = 1;
//            string str2 = "123";

//            //{
//            //    int b = 1;
//            //}
//            //Console.WriteLine(b);
//            //while(true)
//            //{
//            //    int index = 1;
//            //}

//            //想要不被回收或者不变垃圾
//            //必须将其记录下来
//            //如何记录？
//            //在更高层级记录或者
//            //使用静态全局变量记录
//            b = 0;
//            if (true)
//            {
//                b = 1;
//            }

//            int c = 10;
//            Test.TestI = c;

//            //Game g = new Game();
//            //while(true)
//            //{

//            //}
//            #endregion

//            #region 问题四 结构体中的值和引用
//            //结构体本身是值类型
//            //前提：该结构体没有做为其它类的成员
//            //在结构体中的值，栈中存储值具体的内容
//            //在结构体中的引用，堆中存储引用具体的内容

//            //引用类型始终存储在堆中
//            //真正通过结构体使用其中引用类型时只是顺藤摸瓜

//            TestStrict ts = new TestStrict();
//            #endregion

//            #region 问题五 类中的值和引用
//            //类本身是引用类型
//            //在类中的值，堆中存储具体的值
//            //在类中的引用，堆中存储具体的值

//            //值类型跟着大哥走，引用类型一根筋
//            Test t = new Test();
//            #endregion

//            #region 问题六 数组中的存储规则
//            //数组本身是引用类型
//            //值类型数组，堆中房间存具体内容
//            //引用类型数组，堆中房间存地址
//            int[] arrayInt = new int[5];
//            object[] objs = new object[5];
//            #endregion

//            #region 问题七 结构体继承接口
//            //利用里氏替换原则，用接口容器装载结构体存在装箱拆箱

//            TestStruct obj1 = new TestStruct();
//            obj1.Value = 1;
//            Console.WriteLine(obj1.Value);
//            TestStruct obj2 = obj1;
//            obj2.Value = 2;
//            Console.WriteLine(obj1.Value);
//            Console.WriteLine(obj2.Value);

//            ITest iObj1 = obj1;//装箱  value 1
//            ITest iObj2 = iObj1;
//            iObj2.Value = 99;
//            Console.WriteLine(iObj1.Value);
//            Console.WriteLine(iObj2.Value);

//            TestStruct obj3 = (TestStruct)iObj1;//拆箱
//            obj3.Value = 11111;
//            Console.WriteLine(iObj1.Value);
//            Console.WriteLine(iObj2.Value);
//            Console.WriteLine(obj3.Value);
//            #endregion
//        }
//    }

//    interface ITest
//    {
//        int Value
//        {
//            get;
//            set;
//        }
//    }

//    struct TestStruct : ITest
//    {
//        int value;
//        public int Value
//        {
//            get
//            {
//                return value;
//            }
//            set
//            {
//                this.value = value;
//            }

//        }
//    }

//}

namespace Sort_test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 插入排序
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            for (int i = 1; i < arr.Length; ++i)
            {
                int sortindex = i - 1;
                int nownum = arr[i];
                while (sortindex >= 0 && arr[sortindex] > nownum)
                {
                    arr[sortindex + 1] = arr[sortindex];
                    --sortindex;
                }
                arr[sortindex + 1] = nownum;
            }
            foreach (int a in arr) { Console.WriteLine(a); }
            #endregion

            #region
            int[] arr1 = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            for (int step=arr1.Length/2;step>0;step/=2)
            {
                for(int i=step;i<arr1.Length;++i)
                {
                    int nownum = arr1[i];
                    int sortindex = i - step;
                    while(sortindex>=0 && arr1[sortindex]>nownum)
                    {
                        arr1[sortindex + step] = arr1[sortindex];
                        sortindex -= step;
                    }
                    arr1[sortindex + step] = nownum;
                }
            }
            foreach (int a in arr1) { Console.WriteLine(a); }
            #endregion

            #region 
            int[] arr2 = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            Console.WriteLine("123123123");
            arr2 = Merge(arr2);
            foreach (int a in arr2) { Console.WriteLine(a); }
            #endregion

            #region
            Console.WriteLine("快速排序");
            int[] arr3 = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            QuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if(left>=right)
            {
                return;
            }
            int templeft = left;
            int tempright = right;
            int temp = array[left];
            while(templeft<tempright)
            {
                while (array[tempright]>temp && templeft<tempright)
                {
                    tempright--;
                }
                array[templeft] = array[tempright];
                while (array[templeft]<temp && templeft<tempright)
                {
                    templeft++;
                }
                array[tempright] = array[templeft];
            }
            array[templeft] = temp;
            QuickSort(array, left, tempright - 1);
            QuickSort(array, templeft + 1, right);
        }

        public static int[] Sort(int[] left, int[] right)
        {
            int[] array_temp = new int[left.Length + right.Length];
            int left_index = 0;
            int rigth_index = 0;
            int temp_index = 0;
            while(left_index<left.Length && rigth_index<right.Length)
            {
                if (left[left_index] < right[rigth_index])
                {
                    array_temp[temp_index++] = left[left_index];
                    left_index++;
                }
                else
                {
                    array_temp[temp_index++] = right[rigth_index++];
                }
            }
            while(left_index < left.Length)
            {
                array_temp[temp_index++] = left[left_index++];
            }
            while(rigth_index<right.Length)
            {
                array_temp[temp_index++] = right[rigth_index++];
            }
            return array_temp;
        }

        public static int[] Merge(int[] array)
        {
            if(array.Length<2)
            {
                return array;
            }
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] rigth = new int[array.Length - mid];
            for(int i=0;i<array.Length;++i)
            {
                if (i < mid)
                    left[i] = array[i];
                else
                    rigth[i - mid] = array[i];
            }
            return Sort(Merge(left),Merge(rigth));
        }
    }
}