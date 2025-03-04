using System;

//namespace CSharp_opp
//{
//    #region 知识回顾
//    // 实例化对象
//    // Person 变量名;
//    // Person 变量名 = null;
//    // Person 变量名 = new Person();
//    #endregion

//    //#region 知识点一 成员变量
//    //enum E_SexType
//    //{
//    //    Man,
//    //    Woman,
//    //}
//    ////位置结构体
//    //struct Position
//    //{

//    //}
//    ////宠物类
//    //class Pet
//    //{

//    //}
//    //class Person
//    //{
//    //    public string name = "唐老狮";
//    //    public int age;
//    //    public E_SexType sex;
//    //    //如果要在类中申明一个和自己相同类型的成员变量时
//    //    //不能对它进行实例化
//    //    public Person gridFriend;
//    //    public Person[] boyFriend;
//    //    public Position pos;
//    //    private Pet pet = new Pet();
//    //}
//    //#endregion

//    //#region 知识点二 访问修饰符
//    //#endregion

//    #region 知识点一 构造函数
//    //基本概念
//    //在实例化对象时 会调用的用于初始化的函数
//    //如果不写 默认存在一个无参构造函数

//    //构造函数的写法
//    //1.没有返回值
//    //2.函数名和类名必须相同
//    //3.没有特殊需求时 一般都是public的
//    //class Person
//    //{
//    //    public string name;
//    //    public int age;

//    //    //类中是允许自己申明无参构造函数的
//    //    //结构体是不允许
//    //    public Person()
//    //    {
//    //        name = "唐老狮";
//    //        age = 18;
//    //    }

//    //    public Person(int age)
//    //    {
//    //        //this代表当前调用该函数的对象自己 
//    //        this.age = age;
//    //    }

//    //    public Person(string name)
//    //    {
//    //        this.name = name;
//    //    }

//    //    public Person(int age, string name) : this(age + 10)
//    //    {
//    //        Console.WriteLine("Person两个参数构造函数调用");
//    //    }


//    //    //当引用类型的堆内存被回收时
//    //    //析构函数 是当垃圾 真正被回收的时候 才会调用的函数
//    //    ~Person()
//    //    {
//    //        Console.WriteLine("Person析构函数调用");
//    //    }
//    //}

//    //4.构造函数可以被重载
//    //5.this代表当前调用该函数的对象自己

//    //注意：
//    // 如果不自己实现无参构造函数而实现了有参构造函数
//    // 会失去默认的无参构造
//    #endregion

//    #region 知识点二 构造函数特殊写法
//    //可以通过this 重用构造函数代码
//    //访问修饰符 构造函数名(参数列表):this(参数1,参数2....)
//    #endregion

//    #region 知识点四 垃圾回收机制
//    //垃圾回收，英文简写GC（Garbage Collector）
//    //垃圾回收的过程是在遍历堆(Heap)上动态分配的所有对象
//    //通过识别它们是否被引用来确定哪些对象是垃圾，哪些对象仍要被使用
//    //所谓的垃圾就是没有被任何变量，对象引用的内容
//    //垃圾就需要被回收释放

//    //垃圾回收有很多种算法，比如
//    //引用计数(Reference Counting)
//    //标记清除(Mark Sweep)
//    //标记整理(Mark Compact)
//    //复制集合(Copy Collection)

//    //注意：
//    //GC只负责堆(Heap)内存的垃圾回收
//    //引用类型都是存在堆(Heap)中的，所以它的分配和释放都通过垃圾回收机制来管理

//    //栈(Stack)上的内存是由系统自动管理的
//    //值类型在栈(Stack)中分配内存的，他们有自己的生命周期，不用对他们进行管理，会自动分配和释放

//    //C#中内存回收机制的大概原理
//    //0代内存     1代内存     2代内存
//    //代的概念：
//    //代是垃圾回收机制使用的一种算法（分代算法）
//    //新分配的对象都会被配置在第0代内存中
//    //每次分配都可能会进行垃圾回收以释放内存(0代内存满时) ,一代满类似操作，+释放0,1代，2代满释放0,1,2 代

//    //在一次内存回收过程开始时，垃圾回收器会认为堆中全是垃圾，会进行以下两步
//    //1.标记对象 从根（静态字段、方法参数）开始检查引用对象，标记后为可达对象，未标记为不可达对象
//    //  不可达对象就认为是垃圾
//    //2.搬迁对象压缩堆  （挂起执行托管代码线程） 释放未标记的对象 搬迁可达对象 修改引用地址

//    //大对象总被认为是第二代内存  目的是减少性能损耗，提高性能
//    //不会对大对象进行搬迁压缩  85000字节（83kb）以上的对象为大对象
//    #endregion

//    #region 成员属性
//    //基本概念
//    //1.用于保护成员变量
//    //2.为成员属性的获取和赋值添加逻辑处理
//    //3.解决3P的局限性
//    //  public——内外访问
//    //  private——内部访问
//    //  protected——内部和子类访问
//    //  属性可以让成员变量在外部
//    //  只能获取 不能修改  或者  只能修改 不能获取

//    // 访问修饰符 属性类型 属性名
//    // {
//    //     get{}
//    //     set{}
//    // }

//    //class Person_
//    //{
//    //    private string name;
//    //    private int age;
//    //    private int money;
//    //    private bool sex;
//    //    public string Name
//    //    {
//    //        //private get { return name; } //只写不能读
//    //        //private set { name = value; } //只读不能写
//    //        get
//    //        {                //可以在返回之前添加一些逻辑规则 
//    //            //意味着 这个属性可以获取的内容
//    //            return name;
//    //        }
//    //        set
//    //        {                 //可以在设置之前添加一些逻辑规则 
//    //            // value 关键字 用于表示 外部传入的值
//    //            name = value;
//    //        }
//    //    }

//    //    #region 知识点六 自动属性
//    //    //作用：外部能得不能改的特征
//    //    //如果类中有一个特征是只希望外部能得不能改的 又没什么特殊处理
//    //    //那么可以直接使用自动属性
//    //    public float Height
//    //    {
//    //        //没有再get和set中写逻辑的需求或者想法
//    //        get;
//    //        private set;
//    //    }
//    //    #endregion
//    //}

//    #endregion

//    #region 索引器
//    #region 知识点一 索引器基本概念
//    //基本概念
//    //让对象可以像数组一样通过索引访问其中元素，使程序看起来更直观，更容易编写
//    #endregion
//    #region 知识点二 索引器的写法
//    class Person
//    {
//        private string name;
//        private int age;
//        private int money;
//        private Person[] friends;
//        private int[,] array;
//        #region 知识点五 索引器可以重载
//        public int this[int i,int j]
//        {
//            get { return array[i, j]; }
//            set { array[i, j] = value; }
//        }
//        public string this[string str]
//        {
//            get
//            {
//                switch (str)
//                {
//                    case "name":
//                        return this.name;
//                    case "age":
//                        return age.ToString();
//                }
//                return "";
//            }
//        }
//        #endregion
//        public Person this[int index]
//        {
//            get 
//            {
//                //可以写逻辑的 根据需求来处理这里面的内容
//                #region 知识点四 索引器中可以写逻辑
//                if (friends == null ||
//                    friends.Length - 1 < index)
//                {
//                    return null;
//                }
//                #endregion
//                return friends[index]; 
//            }
//            set 
//            {
//                if(friends ==null)
//                {
//                    friends=new Person[] { value };
//                }
//                else if(index>friends.Length-1)
//                {
//                    //自己定了一个规则 如果索引越界 就默认把最后一个朋友顶掉
//                    friends[friends.Length - 1] = value;
//                }
//                friends[index] = value; 
//            }
//        }
//    }
//    #endregion
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Person_ p_=new Person_();
//            //p_.Name = "唐老狮";
//            //Console.WriteLine(p_.Name);
//            //Console.WriteLine("成员变量和访问修饰符");

//            //Person p = new Person( 15,"awei");

//            #region 知识点三 成员变量的使用和初始值
//            //值类型来说 数字类型 默认值都是0  bool类型 false  
//            //引用类型的 null
//            //交给大家一个看默认值的小技巧  default(变量类型) 就能得到默认值
//            //Console.WriteLine(default(Person));

//            //p.age = 10;
//            //Console.WriteLine(p.age);

//            //手动触发垃圾回收的方法 
//            //一般情况下 我们不会频繁调用
//            //都是在 Loading过场景时 才调用
//            GC.Collect();
//            #endregion

//            #region 索引器知识点3
//            Console.WriteLine("索引器知识点3");
//            Person person = new Person();
//            person[0] = new Person();
//            Console.WriteLine(person[0]);

//            #endregion
//        }
//    }
//    //总结
//    //默认值，值不相同
//    //默认值，引用为null
//}

using System;

//namespace Lesson7_封装_静态成员
//{
//    #region 知识回顾
//    class 类名
//    {
//        #region 特征——成员变量

//        #endregion

//        #region 行为——成员方法

//        #endregion

//        #region 初始化调用——构造函数

//        #endregion

//        #region 释放时调用——析构函数

//        #endregion

//        #region 包裹成员变量——成员属性

//        #endregion

//        #region 通过中括号使用对象——索引器
//        #endregion
//    }
//    #endregion

//    #region 知识点一 静态成员基本概念
//    //静态关键字 static
//    //用static修饰的 成员变量、方法、属性等
//    //称为静态成员

//    //静态成员的特点是：直接用类名点出使用
//    #endregion

//    #region 知识点二 早已出现的静态成员

//    #endregion

//    #region 知识点三 自定义静态成员
//    class Test
//    {
//        public const float G = 9.8f;

//        //静态成员变量
//        static public float PI = 3.1415926f;
//        //成员变量
//        public int testInt = 100;

//        //静态成员方法
//        public static float CalcCircle(float r)
//        {
//            #region 知识点六 静态函数中不能使用非静态成员
//            //成员变量只能将对象实例化出来后 才能点出来使用 不能无中生有
//            //不能直接使用 非静态成员 否则会报错
//            //Console.WriteLine(testInt);
//            Test t = new Test();
//            Console.WriteLine(t.testInt);
//            #endregion
//            //πr²
//            return PI * r * r;
//        }
//        //成员方法
//        public void TestFun()
//        {
//            Console.WriteLine("123");
//            #region 知识点七 非静态函数可以使用静态成员
//            Console.WriteLine(PI);
//            Console.WriteLine(CalcCircle(2));
//            #endregion
//        }
//    }
//    #endregion

//    #region 知识点五 为什么可以直接点出来使用
//    //记住！
//    //程序中是不能无中生有的
//    //我们要使用的对象，变量，函数都是要在内存中分配内存空间的
//    //之所以要实例化对象，目的就是分配内存空间，在程序中产生一个抽象的对象

//    //静态成员的特点
//    //程序开始运行时 就会分配内存空间。所以我们就能直接使用。
//    //静态成员和程序同生共死
//    //只要使用了它，直到程序结束时内存空间才会被释放
//    //所以一个静态成员就会有自己唯一的一个“内存小房间”
//    //这让静态成员就有了唯一性
//    //在任何地方使用都是用的小房间里的内容，改变了它也是改变小房间里的内容。
//    #endregion


//    #region 知识点八 静态成员对于我们的作用
//    //静态变量：
//    //1.常用唯一变量的申明 
//    //2.方便别人获取的对象申明
//    //静态方法：
//    //常用的唯一的方法申明 比如 相同规则的数学计算相关函数
//    #endregion

//    #region 知识点九 常量和静态变量
//    //const（常量）可以理解为特殊的static（静态）
//    //相同点
//    //他们都可以通过类名点出使用
//    //不同点
//    //1.const必须初始化，不能修改 static没有这个规则
//    //2.const只能修饰变量、static可以修饰很多
//    //3.const一定是写在访问修饰符后面的 ，static没有这个要求
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("静态成员");
//            #region 知识点四 静态成员的使用
//            Console.WriteLine(Test.PI);
//            Console.WriteLine(Test.G);
//            Console.WriteLine(Test.CalcCircle(2));

//            Test t = new Test();
//            Console.WriteLine(t.testInt);
//            t.TestFun();
//            #endregion
//        }
//    }

//    //总结
//    //概念：用static修饰的成员变量、成员方法、成员属性等 就称为静态成员
//    //特点：直接用类名点出来使用(全局性)
//    //生命周期：和程序同生共死
//    //         程序运行后就会一直存在内存中，知道程序结束后才会释放，因此静态成员具有唯一性
//    //注意：
//    //1.静态函数中不能直接使用非静态成员
//    //2.非静态函数中可以直接使用静态成员

//    //常量和静态变量
//    //常量时特殊的静态变量
//    //相同点
//    //他们都可以通过类名点出来使用
//    //不同点
//    //1.const必须初始化不能被修改 static没有这个规则
//    //2.const只能修饰变量，static可以修饰很多
//    //3.const不能写在访问修饰符前面 一定是写在变量申明前面 static没有这个规则
//}

using System;

//namespace Lesson8_封装_静态类和静态构造函数
//{
//    #region 知识回顾
//    class Person
//    {
//        #region 特征——成员变量

//        #endregion

//        #region 行为——成员方法

//        #endregion

//        #region 初始化调用——构造函数

//        #endregion

//        #region 释放时调用——析构函数

//        #endregion

//        #region 成员属性

//        #endregion

//        #region 索引器

//        #endregion

//        #region 静态成员

//        #endregion
//    }
//    #endregion

//    #region 知识点一 静态类
//    //概念
//    //用static修饰的类

//    //特点
//    //只能包含静态成员
//    //不能被实例化

//    //作用
//    //1.将常用的静态成员写在静态类中 方便使用
//    //2.静态类不能被实例化，更能体现工具类的 唯一性
//    //比如 Console就是一个静态类

//    static class Tools
//    {
//        //静态成员变量
//        public static int testIndex = 0;

//        public static void TestFun()
//        {

//        }

//        public static int TestIndex
//        {
//            get;
//            set;
//        }
//    }
//    #endregion

//    #region 知识点二 静态构造函数
//    //概念
//    // 在构造函数加上 static 修饰

//    //特点
//    //1.静态类和普通类都可以有
//    //2.不能使用访问修饰符
//    //3.不能有参数  
//    //4.只会自动调用一次 ,一般在第一次使用的时候会调用 

//    //作用
//    //在静态构造函数中初始化 静态变量

//    //使用
//    //1.静态类中的静态构造函数
//    static class StaticClass
//    {
//        public static int testInt = 100;
//        public static int testInt2 = 100;
//        static StaticClass()
//        {
//            Console.WriteLine("静态构造函数");
//            testInt = 200;
//            testInt2 = 300;
//        }
//    }

//    //2.普通类中的静态构造函数
//    class Test
//    {
//        public static int testInt = 200;
//        static Test() 
//        {
//            Console.WriteLine("静态构造");
//        }

//        public Test()
//        {
//            Console.WriteLine("普通构造");
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("静态类和静态构造函数!");

//            Console.WriteLine(StaticClass.testInt);
//            Console.WriteLine(StaticClass.testInt2);
//            Console.WriteLine(StaticClass.testInt);

//            //Console.WriteLine(Test.testInt);
//            Test t = new Test();
//            Test t2 = new Test();
//        }
//    }

//    //总结
//    //静态类
//    //用static 修饰的类
//    //特点
//    //只能包含静态成员
//    //不能实例化
//    //作用
//    //工具类
//    //拓展方法

//    //静态构造函数
//    //用static修饰的构造函数
//    //特点
//    //静态类和普通类都可以有静态构造函数
//    //不能使用访问修饰符
//    //不能有参数
//    //只会自动调用一次
//    //作用
//    //初始化静态成员
//}

using System;

//namespace Lesson9_封装_拓展方法
//{
//    #region 知识回顾
//    class 类名
//    {
//        #region 特征——成员变量

//        #endregion

//        #region 行为——成员方法

//        #endregion

//        #region 初始化调用——构造函数

//        #endregion

//        #region 释放时调用——析构函数

//        #endregion

//        #region 成员属性

//        #endregion

//        #region 索引器

//        #endregion

//        #region 静态成员

//        #endregion
//    }

//    #region 静态类和静态构造函数

//    #endregion
//    #endregion

//    #region 知识点一 拓展方法基本概念
//    //概念 
//    //为现有非静态 变量类型 添加 新方法
//    //作用
//    //1.提升程序拓展性
//    //2.不需要再对象中重新写方法
//    //3.不需要继承来添加方法
//    //4.为别人封装的类型写额外的方法
//    //特点
//    //1.一定是写在静态类中
//    //2.一定是个静态函数
//    //3.第一个参数为拓展目标
//    //4.第一个参数用this修饰
//    #endregion

//    #region 知识点二 基本语法
//    //访问修饰符 static 返回值 函数名(this 拓展类名 参数名, 参数类型 参数名,参数类型 参数名....)
//    #endregion

//    #region 知识点三 实例
//    static class Tools
//    {
//        //为int拓展了一个成员方法
//        //成员方法 是需要 实例化对象后 才 能使用的
//        //value 代表 使用该方法的 实例化对象
//        public static void SpeakValue_(this int value) 
//        {
//            //拓展的方法 的逻辑
//            Console.WriteLine("唐老狮为int拓展的方法" + value);
//        }
//        public static void SpeakValue(this int value)
//        {
//            //拓展的方法 的逻辑
//            Console.WriteLine("唐老狮为int拓展的方法" + value);
//        }

//        public static void SpeakStringInfo(this string str, string str2, string str3)
//        {
//            Console.WriteLine("唐老狮为string拓展的方法");
//            Console.WriteLine("调用方法的对象" + str);
//            Console.WriteLine("传的参数" + str2 + str3);
//        }

//        public static void Fun3(this Test t)
//        {
//            Console.WriteLine("为test拓展的方法");
//        }

//        public static int Fun4(this Test t,int i)
//        {
//            Console.WriteLine("为test拓展的方法");
//            return i;
//        }

//    }

//    #endregion

//    #region 知识点五 为自定义的类型拓展方法
//    class Test
//    {
//        public int i = 10;
//        public void Fun1()
//        {
//            Console.WriteLine("123");
//        }

//        public void Fun2()
//        {
//            Console.WriteLine("456");
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("拓展方法");
//            #region 知识点四 使用
//            int i = 10;
//            i.SpeakValue();
//            i.SpeakValue_();

//            string str = "000";
//            str.SpeakStringInfo("唐老狮", "111");

//            Test t = new Test();
//            t.Fun2();
//            Console.WriteLine(t.Fun4(100));
//            #endregion
//        }
//    }

//    //总结：
//    //概念：为现有的非静态 变量类型 添加 方法
//    //作用：
//    // 提升程序拓展性
//    // 不需要再在对象中重新写方法
//    // 不需要继承来添加方法
//    // 为别人封装的类型写额外的方法

//    //特点：
//    //静态类中的静态方法
//    //第一个参数 代表拓展的目标
//    //第一个参数前面一定要加 this

//    //注意：
//    //可以有返回值 和 n个参数
//    //根据需求而定
//}

using System;

//namespace Lesson10_封装_运算符重载
//{
//    #region 知识点一 基本概念
//    //概念
//    //让自定义类和结构体
//    //能够使用运算符

//    //使用关键字 
//    //operator

//    //特点
//    //1.一定是一个公共的静态方法
//    //2.返回值写在operator前
//    //3.逻辑处理自定义

//    //作用
//    //让自定义类和结构体对象可以进行运算
//    //注意
//    //1.条件运算符需要成对实现
//    //2.一个符号可以多个重载
//    //3.不能使用ref和out
//    #endregion

//    #region 知识点二 基本语法
//    //public static 返回类型 operator 运算符(参数列表)
//    #endregion

//    #region 知识点三 实例
//    class Point
//    {
//        public int x;
//        public int y;
//        public static Point operator+(Point p1,Point p2)
//        {
//            Point p = new Point();
//            p.x = p1.x + p2.x;
//            p.y = p1.y + p2.y;
//            return p;
//        }

//        public static Point operator +(Point p1, int value)
//        {
//            Point p = new Point();
//            p.x = p1.x + value;
//            p.y = p1.y + value;
//            return p;
//        }

//        public static Point operator +(int value, Point p1)
//        {
//            Point p = new Point();
//            p.x = p1.x + value;
//            p.y = p1.y + value;
//            return p;
//        }

//        #region 可重载的运算符

//        #region 算数运算符
//        //注意 符号需要两个参数还是一个参数
//        public static Point operator -(Point p1, Point P2)
//        {
//            return null;
//        }
//        public static Point operator *(Point p1, Point P2)
//        {
//            return null;
//        }
//        public static Point operator /(Point p1, Point P2)
//        {
//            return null;
//        }
//        public static Point operator %(Point p1, Point P2)
//        {
//            return null;
//        }

//        public static Point operator ++(Point p1)
//        {
//            return null;
//        }
//        public static Point operator --(Point p1)
//        {
//            return null;
//        }
//        #endregion

//        #region 逻辑运算符
//        //注意 符号需要两个参数还是一个参数
//        public static bool operator !(Point p1)
//        {
//            return false;
//        }
//        #endregion

//        #region 位运算符
//        //注意 符号需要两个参数还是一个参数
//        public static Point operator |(Point p1, Point p2)
//        {
//            return null;
//        }
//        public static Point operator &(Point p1, Point p2)
//        {
//            return null;
//        }
//        public static Point operator ^(Point p1, Point p2)
//        {
//            return null;
//        }
//        public static Point operator ~(Point p1)
//        {
//            return null;
//        }
//        public static Point operator <<(Point p1, int num)
//        {
//            return null;
//        }
//        public static Point operator >>(Point p1, int num)
//        {
//            return null;
//        }
//        #endregion

//        #region 条件运算符
//        //1.返回值一般是bool值 也可以是其它的
//        //2.相关符号必须配对实现
//        public static bool operator >(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator <(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator >=(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator <=(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator ==(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator !=(Point p1, Point p2)
//        {
//            return false;
//        }
//        public static bool operator true(Point p1)
//        {
//            return false;
//        }
//        public static bool operator false(Point p1)
//        {
//            return false;
//        }
//        #endregion
//        #endregion

//        #region 不可重载的运算符
//        //逻辑与(&&) 逻辑或(||)
//        //索引符 []
//        //强转运算符 ()
//        //特殊运算符 
//        //点.   三目运算符? :  赋值符号=

//        #endregion
//    }
//    #endregion

//    #region 知识点五 可重载和不可重载的运算符

//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("运算符重载");

//            #region 知识点四 使用

//            Point p = new Point();
//            p.x = 1;
//            p.y = 1;
//            Point p2 = new Point();
//            p2.x = 2;
//            p2.y = 2;

//            Point p3 = p + p2;

//            Point p4 = p3 + 2;
//            Point p5 = 2 + p3;


//            #endregion
//        }
//    }

//    //总结
//    //关键
//    //operator
//    //固定语法：
//    //public static 返回值 operator 运算符(参数列表)
//    //作用：
//    //让子弟定义类或结构体对象 进行运算
//    //注意：
//    //1.参数的数量
//    //2.条件运算符的配对实现
//    //3.一个符号可以多个重载
//    //4.不能用ref和out
//}

using System;

namespace Lesson11_封装_内部类和分部类
{
    #region 知识回顾
    class 类名
    {
        #region 特征——成员变量

        #endregion

        #region 行为——成员方法

        #endregion

        #region 初始化调用——构造函数

        #endregion

        #region 释放时调用——析构函数

        #endregion

        #region 保护成员变量——成员属性

        #endregion

        #region 像数组一样使用——索引器

        #endregion

        #region 类名点出使用——静态成员

        #endregion

        #region 自定义对象可计算——运算符重载

        #endregion
    }

    #region 静态类和静态构造函数

    #endregion

    #region 拓展方法

    #endregion

    #endregion

    #region 知识点一 内部类
    //概念
    //在一个类中再申明一个类

    //特点
    //使用时要用包裹者点出自己

    //作用
    //亲密关系的变现

    //注意
    //访问修饰符作用很大

    class Person
    {
        public int age;
        public string name;
        public Body body;
        public class Body
        {
            Arm leftArm;
            Arm rightArm;
            class Arm
            {

            }
        }
    }
    #endregion

    #region 知识点二 分部类
    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //作用
    //分部描述一个类
    //增加程序的拓展性

    //注意
    //分部类可以写在多个脚本文件中
    //分部类的访问修饰符要一致
    //分部类中不能有重复成员

    public partial class Student
    {
        public int shabi;
    }
    public partial class Student
    {
        public bool sex;
        public string name;

        partial void Speak(); //分部方法的申明
    }

    partial class Student
    {
        public int number;

        partial void Speak() //分部方法的实现
        {
            //实现逻辑
        }

        public void Speak(string str)
        {

        }
    }

    #endregion

    #region 知识点三 分部方法
    //概念
    //将方法的申明和实现分离
    //特点
    //1.不能加访问修饰符 默认私有
    //2.只能在分部类中申明
    //3.返回值只能是void
    //4.可以有参数但不用 out关键字

    //局限性大，了解即可
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分部类");

            Person p = new Person();

            Person.Body body = new Person.Body();
        }
    }
}



