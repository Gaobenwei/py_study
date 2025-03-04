using System;

//namespace Lesson12_继承_继承的基本规则
//{
//    #region 知识点一 基本概念
//    //一个类A继承一个类B
//    //类A将会继承类B的所有成员
//    //A类将拥有B类的所有特征和行为

//    //被继承的类
//    //称为 父类、基类、超类

//    //继承的类
//    //称为子类、派生类

//    //子类可以有自己的特征和行为    

//    //特点
//    //1.单根性 子类只能有一个父类
//    //2.传递性 子类可以间接继承父类的父类  
//    #endregion

//    #region 知识点二 基本语法
//    //class 类名 : 被继承的类名
//    //{

//    //}
//    #endregion

//    #region 知识点三 实例

//    class Test
//    {

//    }

//    class Teacher
//    {
//        //姓名
//        public string name;
//        //职工号
//        protected int number;
//        //介绍名字
//        public void SpeakName()
//        {
//            number = 10;
//            Console.WriteLine(name);
//        }
//    }

//    class TeachingTeacher : Teacher
//    {
//        //科目
//        public string subject;
//        //介绍科目
//        public void SpeakSubject()
//        {
//            number = 11;
//            Console.WriteLine(subject + "老师");
//        }
//    }

//    class ChineseTeacher : TeachingTeacher
//    {
//        public void Skill()
//        {
//            Console.WriteLine("一行白鹭上青天");
//        }
//    }

//    #endregion

//    #region 知识点四 访问修饰符的影响
//    //public - 公共 内外部访问
//    //private - 私有 内部访问
//    //protected - 保护 内部和子类访问

//    //之后讲命名空间的时候讲
//    //internal - 内部的 只有在同一个程序集的文件中，内部类型或者是成员才可以访问
//    #endregion

//    #region 知识点五 子类和父类的同名成员
//    //概念 
//    //C#中允许子类存在和父类同名的成员
//    //但是 极不建议使用
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("继承的基本规则");

//            TeachingTeacher tt = new TeachingTeacher();
//            tt.name = "唐老狮";
//            //tt.number = 1;
//            tt.SpeakName();

//            tt.subject = "Unity";
//            tt.SpeakSubject();

//            ChineseTeacher ct = new ChineseTeacher();
//            ct.name = "唐老师";
//            //ct.number = 2;
//            ct.subject = "语文";
//            ct.SpeakName();
//            ct.SpeakSubject();
//            ct.Skill();
//        }
//    }
//    //总结
//    //继承基本语法
//    // class 类名:父类名
//    // 1.单根性：只能继承一个父类
//    // 2.传递性：子类可以继承父类的父类。。。的所有内容
//    // 3.访问修饰符 对于成员的影响

//    // 4.极奇不建议使用 在子类中申明和父类同名的成员（以后学习了多态再来解决这个问题）
//}


using System;

//namespace Lesson13_继承_里氏替换原则
//{
//    #region 知识点一 基本概念
//    // 里氏替换原则是面向对象七大原则中最重要的原则
//    // 概念：
//    // 任何父类出现的地方，子类都可以替代
//    // 重点：
//    // 语法表现——父类容器装子类对象,因为子类对象包含了父类的所有内容
//    // 作用：
//    // 方便进行对象存储和管理
//    #endregion

//    #region 知识点二 基本实现
//    class GameObject
//    {

//    }

//    class Player : GameObject
//    {
//        public void PlayerAtk()
//        {
//            Console.WriteLine("玩家攻击");
//        }
//    }

//    class Monster : GameObject
//    {
//        public void MonsterAtk()
//        {
//            Console.WriteLine("怪物攻击");
//        }
//    }

//    class Boss : GameObject
//    {
//        public void BossAtk()
//        {
//            Console.WriteLine("Boss攻击");
//        }
//    }
//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("里氏替换原则");

//            //里氏替换原则 用父类容器 装载子类对象
//            GameObject player = new Player();
//            GameObject monster = new Monster();
//            GameObject boss = new Boss();

//            GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss() };

//            #region 知识点三 is和as
//            //基本概念 
//            // is：判断一个对象是否是指定类对象
//            // 返回值：bool  是为真 不是为假

//            // as：将一个对象转换为指定类对象
//            // 返回值：指定类型对象
//            // 成功返回指定类型对象，失败返回null

//            //基本语法
//            // 类对象 is 类名   该语句块 会有一个bool返回值 true和false
//            // 类对象 as 类名   该语句块 会有一个对象返回值 对象和null

//            if (player is Player)
//            {
//                Player p = player as Player;
//                p.PlayerAtk();
//                //(player as Player).PlayerAtk();
//            }

//            for (int i = 0; i < objects.Length; i++)
//            {
//                if (objects[i] is Player)
//                {
//                    (objects[i] as Player).PlayerAtk();
//                }
//                else if (objects[i] is Monster)
//                {
//                    (objects[i] as Monster).MonsterAtk();
//                }
//                else if (objects[i] is Boss)
//                {
//                    (objects[i] as Boss).BossAtk();
//                }
//            }

//            #endregion
//        }
//    }
//    //总结
//    //概念：父类容器装子类对象
//    //作用：方便进行对象的存储和管理
//    //使用：is和as
//    // is 用于判断
//    // as 用于转换
//    // 注意：不能用子类容器装父类对象
//}

using System;

//namespace Lesson14_继承_继承中的构造函数
//{
//    #region 知识回顾
//    //构造函数
//    //实例化对象时调用的函数
//    //主要用来初始化成员变量
//    //每个类 都会有一个默认的无参构造函数

//    //语法
//    // 访问修饰符 类名()
//    // {
//    // }
//    //不写返回值
//    //函数名和类名相同
//    //访问修饰符根据需求而定,一般为public
//    //构造函数可以重载
//    //可以用this语法重用代码

//    //注意
//    //有参构造会顶掉默认的无参构造
//    //如想保留无参构造需重载出来

//    class Test
//    {
//        public int testI;
//        public string testStr;
//        public Test()
//        {

//        }

//        public Test(int i)
//        {
//            this.testI = i;
//        }
//        public Test(int i, string str) : this(i)
//        {
//            this.testStr = str;
//        }
//    }
//    #endregion

//    #region 知识点一 继承中的构造函数 基本概念
//    //特点
//    //当申明一个子类对象时
//    //先执行父类的构造函数
//    //再执行子类的构造函数

//    //注意：
//    //1.父类的无参构造 很重要
//    //2.子类可以通过base关键字 代表父类 调用父类构造
//    #endregion

//    #region 知识点二 继承中构造函数的执行顺序
//    // 父类的父类的构造——>。。。父类构造——>。。。——>子类构造
//    class GameObject
//    {
//        public GameObject()
//        {
//            Console.WriteLine("GameObject的构造函数");
//        }
//    }
//    class Player : GameObject
//    {
//        public Player()
//        {
//            Console.WriteLine("Player的构造函数");
//        }
//    }
//    class MainPlayer : Player
//    {
//        public MainPlayer()
//        {
//            Console.WriteLine("MainPlayer的构造函数");
//        }
//    }
//    #endregion

//    #region 知识点三 父类的无参构造函重要
//    //子类实例化时 默认自动调用的 是父类的无参构造 所以如果父类无参构造被顶掉 会报错
//    class Father
//    {
//        //public Father()
//        //{

//        //}

//        public Father(int i)
//        {
//            Console.WriteLine("Father构造");
//        }
//    }


//    class Son : Father
//    {
//        #region 知识点四 通过base调用指定父类构造
//         public Son(int i):base(i)
//        {
//            Console.WriteLine("Son的一个参数的构造");
//        }

//        public Son(int i, string str) : this(i)
//        {
//            Console.WriteLine("Son的两个参数的构造");
//        }
//        #endregion
//    }

//    #endregion


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("继承中的构造函数");

//            MainPlayer mp = new MainPlayer();

//            Son s = new Son(1, "123");
//        }
//    }

//    //总结
//    //继承中的构造函数
//    //特点
//    //执行顺序 是先执行父类的构造函数 再执行子类的 从老祖宗开始 依次一代一代向下执行

//    //父类中的无参构造函数 很重要
//    //如果被顶掉 子类中就无法默认调用无参构造了
//    //解决方法：
//    //1.始终保持申明一个无参构造
//    //2.通过base关键字 调用指定父类的构造
//    //注意：
//    //区分this和base的区别
//}

using System;

//namespace Lesson15_封装_万物之父和装箱拆箱
//{
//    #region 里氏替换知识点回顾
//    //概念：父类容器装子类对象
//    //作用：方便进行对象存储和管理
//    //使用：
//    //is和as
//    //is用于判断
//    //as用于转换
//    class Father
//    {

//    }
//    class Son : Father
//    {
//        public void Speak()
//        {

//        }
//    }
//    #endregion

//    #region 知识点一 万物之父
//    //万物之父
//    //关键字：object
//    //概念：
//    //object是所有类型的基类，它是一个类（引用类型）
//    //作用：
//    //1.可以利用里氏替换原则，用object容器装所有对象
//    //2.可以用来表示不确定类型，作为函数参数类型
//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("万物之父和装箱拆箱");
//            #region 知识点二 万物之父的使用
//            Father f = new Son();
//            if (f is Son)
//            {
//                (f as Son).Speak();
//            }

//            //引用类型 
//            object o = new Son();
//            //用is as 来判断和转换即可
//            if (o is Son)
//            {
//                (o as Son).Speak();
//            }
//            //值类型 
//            object o2 = 1f;
//            //用强转
//            float fl = (float)o2;

//            //特殊的string类型
//            object str = "123123";
//            string str2 = str as string;
//            string str3 = (string)str;
//            string str4 = str.ToString();

//            object arr = new int[10];
//            int[] ar = arr as int[];
//            int[] ar2 = (int[])arr;
//            #endregion

//            #region 知识点三 装箱拆箱
//            //发生条件
//            //用object存值类型（装箱）
//            //再把object转为值类型（拆箱）

//            //装箱
//            //把值类型用引用类型存储
//            //栈内存会迁移到堆内存中

//            //拆箱
//            //把引用类型存储的值类型取出来
//            //堆内存会迁移到栈内存中

//            //好处：不确定类型时可以方便参数的存储和传递
//            //坏处：存在内存迁移，增加性能消耗

//            //装箱
//            object v = 3;
//            //拆箱
//            int intValue = (int)v;

//            TestFun(1, 2, 3, 4f, 34.5, "123123", new Son());
//            #endregion
//        }

//        static void TestFun(params object[] array) //配合使用达到任意类型任意数量的参数传递
//        {

//        }
//    }

//    //总结：
//    //万物之父：object
//    //基于里氏替换原则的 可以用object容器装载一切类型的变量
//    //它是所有类型的基类

//    // 装箱拆箱
//    // 用object存值类型（装箱）
//    // 把object里面存的值 转换出来(拆箱)
//    // 好处
//    // 不去定类型时可以用 方便参数存储和传递
//    // 坏处
//    // 存在内存的迁移 增加了性能消耗

//    // 不是不用，尽量少用
//}

using System;

namespace Lesson16_继承_密封类
{
    #region 知识点一 基本概念
    //密封类 是使用 sealed密封关键字修饰的类
    //作用：让类无法再被继承
    #endregion

    #region 知识点二 实例
    class Father
    {

    }

    sealed class Son : Father
    {

    }
    #endregion

    #region 知识点三 作用
    //在面向对象程序的设计中，密封类的主要作用就是不允许最底层子类被继承
    //可以保证程序的规范性、安全性
    //目前对于大家来说 可能用处不大
    //随着大家的成长，以后制作复杂系统或者程序框架时 便能慢慢体会到密封的作用
    #endregion

    //总结
    // 关键字：sealed
    // 作用：让类无法再被继承
    // 意义： 加强面向对象程序设计的 规范性、结构性、安全性
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封类");
        }
    }
}

