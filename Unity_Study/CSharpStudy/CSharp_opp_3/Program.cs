using System;

//namespace Lesson17_多态_vob
//{
//    #region 抽象类
//    //又叫 纯虚方法
//    //用 abstract关键字修饰的方法
//    //特点：
//    //1.只能在抽象类中申明
//    //2.没有方法体
//    //3.不能是私有的
//    //4.继承后必须实现 用override重写
//    abstract class Thing
//    {
//        //抽象类中 封装的所有知识点都可以在其中书写
//        public string name;
//        //可以在抽象类中写抽象函数
//    }

//    class Water : Thing
//    {

//    }

//    abstract class Fruits
//    {
//        public string name;

//        //抽象方法 是一定不能有函数体的
//        public abstract void Bad();

//        public virtual void Test()
//        {
//            //可以选择是否写逻辑
//        }
//    }

//    class Apple : Fruits
//    {
//        public override void Bad()
//        {

//        }
//        //虚方法是可以由我们子类选择性来实现的
//        //抽象方法必须要实现
//    }

//    class SuperApple : Apple
//    {

//        //虚方法和抽象方法 都可以被子类无限的 去重写
//        public override void Bad()
//        {
//            base.Bad();
//        }

//        public override void Test()
//        {
//            base.Test();
//        }
//    }
//    #endregion

//    #region 知识回顾

//    #region 封装——用程序语言来形容对象
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

//        #region 保护成员变量——成员属性

//        #endregion

//        #region 像数组一样使用——索引器

//        #endregion

//        #region 类名点出使用——静态成员

//        #endregion

//        #region 自定义对象可计算——运算符重载

//        #endregion
//    }

//    #region 静态类和静态构造函数

//    #endregion

//    #region 拓展方法

//    #endregion
//    #endregion

//    #region 继承——复用封装对象的代码；儿子继承父亲，复用现成代码

//    #region 继承中的构造函数

//    #endregion

//    #region 里氏替换原则

//    #endregion

//    #region 万物之父

//    #endregion

//    #region 装箱拆箱

//    #endregion

//    #region 密封类

//    #endregion

//    #endregion

//    #endregion

//    #region 知识点一 多态的概念
//    // 多态按字面的意思就是“多种状态”
//    // 让继承同一父类的子类们 在执行相同方法时有不同的表现（状态）
//    // 主要目的
//    // 同一父类的对象 执行相同行为（方法）有不同的表现
//    // 解决的问题
//    // 让同一个对象有唯一行为的特征
//    #endregion

//    #region 知识点二 解决的问题
//    class Father
//    {
//        public void SpeakName()
//        {
//            Console.WriteLine("Father的方法");
//        }
//    }

//    class Son : Father
//    {
//        public new void SpeakName()
//        {
//            Console.WriteLine("Son的方法");
//        }
//    }
//    #endregion

//    #region 知识点三 多态的实现
//    //我们目前已经学过的多态
//    //编译时多态——函数重载，开始就写好的

//    //我们将学习的：
//    //运行时多态( vob、抽象函数、接口 )
//    //我们今天学习 vob
//    //v: virtual(虚函数)
//    //o: override(重写)
//    //b: base(父类)

//    class GameObject
//    {
//        public string name;
//        public GameObject(string name)
//        {
//            this.name = name;
//        }

//        //虚函数 可以被子类重写
//        public virtual void Atk()
//        {
//            Console.WriteLine("游戏对象进行攻击");
//        }
//    }

//    class Player : GameObject
//    {
//        public Player(string name) : base(name)
//        {

//        }

//        //重写虚函数
//        public override void Atk()
//        {
//            //base的作用
//            //代表父类 可以通过base来保留父类的行为
//            base.Atk();
//            Console.WriteLine("玩家对象进行攻击");
//        }
//    }

//    class Monster : GameObject
//    {
//        public Monster(string name) : base(name)
//        {

//        }

//        public override void Atk()
//        {
//            Console.WriteLine("怪物对象进行攻击");
//        }
//    }

//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("抽象类和抽象方法");
//            //抽象不能被实例化
//            //Thing t = new Thing();
//            //但是 可以遵循里氏替换原则 用父类容器装子类
//            Thing t = new Water();

//            Console.WriteLine("多态vob");

//            #region 解决的问题
//            Father f = new Son();
//            f.SpeakName();
//            (f as Son).SpeakName();
//            #endregion

//            #region 多态的使用
//            GameObject p = new Player("唐老狮");
//            p.Atk();
//            (p as Player).Atk();

//            GameObject m = new Monster("小怪物");
//            m.Atk();
//            (m as Monster).Atk();
//            #endregion
//        }
//    }

//    //总结：
//    //多态：让同一类型的对象，执行相同行为时有不同的表现
//    //解决的问题： 让同一对象有唯一的行为特征
//    //vob:
//    // v:virtual 虚函数
//    // o:override 重写
//    // b:base 父类
//    // v和o一定是结合使用的 来实现多态
//    // b是否使用根据实际需求 保留父类行为
//}


using System;

//namespace Lesson19_多态_接口
//{
//    #region 知识点一 接口的概念
//    //接口是行为的抽象规范
//    //它也是一种自定义类型
//    //关键字 ：interface

//    //接口申明的规范
//    //1.不包含成员变量
//    //2.只包含方法、属性、索引器、事件
//    //3.成员不能被实现
//    //4.成员可以不用写访问修饰符，不能是私有的
//    //5.接口不能继承类，但是可以继承另一个接口

//    //接口的使用规范
//    //1.类可以继承多个接口
//    //2.类继承接口后，必须实现接口中所有成员

//    //特点：
//    //1.它和类的申明类似
//    //2.接口是用来继承的
//    //3.接口不能被实例化，但是可以作为容器存储对象
//    #endregion

//    #region 知识点二 接口的申明
//    //接口关键字：interface
//    //语法：
//    // interface 接口名
//    // {
//    // }
//    //一句话记忆：接口是抽象行为的“基类”
//    //接口命名规范 帕斯卡前面加个I

//    interface IFly
//    {
//        void Fly();
//        string Name
//        { get; set; }
//        public int this[int index]
//        {
//            get;
//            set;
//        }
//        event Action doSomthing; //事件
//    }
//    #endregion

//    #region 知识点三 接口的使用
//    //接口用来继承
//    class Animal
//    {

//    }

//    //1.类可以继承1个类，n个接口
//    //2.继承了接口后 必须实现其中的内容 并且必须是public的
//    class Person : Animal, IFly
//    {
//        //3.实现的接口函数，可以加v再在子类重写
//        public virtual void Fly()
//        {

//        }

//        public string Name
//        {
//            get;
//            set;
//        }

//        public int this[int index]
//        {
//            get
//            {
//                return 0;
//            }
//            set
//            {

//            }
//        }

//        public event Action doSomthing;
//    }


//    #endregion

//    #region 知识点四 接口可以继承接口
//    //接口继承接口时  不需要实现
//    //待类继承接口后  类自己去实现所有内容
//    interface IWalk
//    {
//        void Walk();
//    }

//    interface IMove : IFly, IWalk
//    {
//    }

//    class Test : IMove
//    {
//        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public event Action doSomthing;

//        public void Fly()
//        {
//            throw new NotImplementedException();
//        }

//        public void Walk()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    #endregion

//    #region 知识点五 显示实现接口
//    //当一个类继承两个接口
//    //但是接口中存在着同名方法时
//    //注意：显示实现接口时 不能写访问修饰符

//    interface IAtk
//    {
//        void Atk();
//    }

//    interface ISuperAtk
//    {
//        void Atk();
//    }

//    class Player : IAtk, ISuperAtk
//    {
//        //显示实现接口 就是用 接口名.行为名 去实现
//        void IAtk.Atk()
//        {

//        }

//        void ISuperAtk.Atk()
//        {

//        }

//        public void Atk()
//        {

//        }
//    }

//    interface func1
//    {
//        protected void func();
//    }
//    interface func2: func1
//    {
        
//    }
//    class hah:func2
//    {
//        void func1.func()
//        {
//            Console.WriteLine("func2");
//        }
//    }

//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("接口");
//            //4.接口也遵循里氏替换原则
//            IFly f = new Person();

//            IMove im = new Test();
//            IFly ifly = new Test();
//            IWalk iw = new Test();

//            IAtk ia = new Player();
//            ISuperAtk isa = new Player();
//            ia.Atk();
//            isa.Atk();

//            Player p = new Player();
//            (p as IAtk).Atk();
//            (p as ISuperAtk).Atk();
//            p.Atk();
//        }
//    }

//    //总结：
//    //继承类：是对象间的继承，包括特征行为等等
//    //继承接口：是行为间的继承，继承接口的行为规范，按照规范去实现内容
//    //由于接口也是遵循里氏替换原则，所以可以用接口容器装对象
//    //那么久可以实现 装载各种毫无关系但是却有相同行为的对象

//    //注意：
//    //1.接口值包含 成员方法、属性、索引器、事件，并且都不实现，都没有访问修饰符
//    //2.可以继承多个接口，但是只能继承一个类
//    //3.接口可以继承接口，相当于在进行行为合并，待子类继承时再去实现具体的行为
//    //4.接口可以被显示实现 主要用于实现不同接口中的同名函数的不同表现
//    //5.实现的接口方法 可以加 virtual关键字 之后子类 再重写
//}

using System;

//namespace Lesson20_多态_密封方法
//{
//    #region 知识回顾
//    //密封类
//    //用sealed修饰的类
//    //让类不再能被继承  “结扎”
//    #endregion

//    #region 知识点一 密封方法基本概念
//    //用密封关键字sealed 修饰的重写函数
//    //作用：让虚方法或者抽象方法之后不能再被重写
//    //特点：和override一起出现
//    #endregion

//    #region 知识点二 实例
//    abstract class Animal
//    {
//        public string name;
//        public abstract void Eat();

//        public virtual void Speak()
//        {
//            Console.WriteLine("叫");
//        }
//    }

//    class Person : Animal
//    {
//        public override void Eat()
//        {

//        }

//        public override void Speak()
//        {

//        }
//    }

//    class WhitePerson : Person
//    {
//        public sealed override void Eat()
//        {
//            base.Eat();
//        }

//        public sealed override void Speak()
//        {
//            base.Speak();
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("密封方法");
//        }
//    }

//    //总结
//    //密封方法 可以让虚方法和抽象方法不能再被子类重写
//    // 特点：一定是和override一起出现
//}

//引用MyGame命名空间
using System;
using MyGame;
using MyGame.UI;

#region 知识点一 命名空间基本概念
//概念
//命名空间是用来组织和重用代码的
//作用
//就像是一个工具包，类就像是一件一件的工具，都是申明在命名空间中的
#endregion

#region 知识点二 命名空间的使用
//基本语法
//namespace 命名空间名
//{
//  类
//  类
//}
namespace MyGame
{
    class GameObject
    {

    }
}

namespace MyGame
{
    class Player : GameObject
    {

    }
}
#endregion


#region 知识点四 不同命名空间中允许有同名类
namespace MyGame2
{
    //在不同的命名空间中 是可以有同名类的
    class GameObject
    {

    }
}
#endregion

#region 知识点五 命名空间可以包裹命名空间
namespace MyGame
{
    namespace UI
    {
        class Image
        {

        }
    }

    namespace Game
    {
        class Image
        {

        }
    }
}
#endregion

#region 知识点六 关于修饰类的访问修饰符
//public   —— 命名空间中的类 默认为public
//internal —— 只能在该程序集中使用
//abstract —— 抽象类
//sealed   —— 密封类
//partial  —— 分部类
#endregion

namespace Lesson21_面向对象相关_命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");
            #region 知识点三 不同命名空间中相互使用 需要引用命名空间或指明出处
            GameObject g = new GameObject();

            Image img0 = new Image();
            MyGame.UI.Image img = new MyGame.UI.Image();
            MyGame.Game.Image img2 = new MyGame.Game.Image();
            #endregion
        }
    }
}

//总结
//1.命名空间是个工具包 用来管理类的
//2.不同命名空间中 可以有同名类
//3.不同命名空间中相互使用 需要using引用命名空间 或者 指明出处
//4.命名空间可以包裹命名空间

