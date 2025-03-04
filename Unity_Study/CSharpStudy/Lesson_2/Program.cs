using System;

//namespace Lesson12_练习题
//{
//    #region 练习题
//    //写一个人类，人类中有姓名，年龄属性，有说话行为
//    //战士类继承人类，有攻击行为

//    class Warrior : Person
//    {
//        public void Atk(Warrior otherWarrior)
//        {
//            Console.WriteLine("{0}打了{1}", Name, otherWarrior.Name);
//        }
//    }

//    class Person
//    {
//        private string _Name;
//        public string Name
//        {
//            get { return this._Name; }
//            set { this._Name = value; }
//        }
//        private int Age
//        {
//            get;
//            set;
//        }
//        public void Speak(string str)
//        {
//            Age = 10;
//            Console.WriteLine(Age);
//            Console.WriteLine(str);
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("继承练习题");

//            Warrior w1 = new Warrior();
//            w1.Name = "唐老狮";
//            Warrior w2 = new Warrior();
//            w2.Name = "奥特曼";
//            w1.Name = "hello";
//            Console.WriteLine(w1.Name);
//            w1.Atk(w2);
//            w1.Speak("123");
//        }
//    }
//}

//namespace Lesson13_练习题
//{
//    #region 练习题一
//    //is和as的区别是什么
//    // is 用于判断  类对象判断是不是某一个类型的对象   bool 
//    // as 用于转换  把一个类对象 转换成一个指定类型的对象   null
//    #endregion

//    #region 练习题二
//    //写一个Monster类，它派生出Boss和Goblin两个类，
//    //Boss有技能；小怪有攻击；
//    //随机生成10个怪，装载到数组中
//    //遍历这个数组，调用他们的攻击方法，如果是boss就释放技能
//    class Monster
//    {
//    }
//    class Boss : Monster
//    {
//        public void Skill()
//        {
//            Console.WriteLine("Boss释放技能");
//        }
//    }
//    class Goblin : Monster
//    {
//        public void Atk()
//        {
//            Console.WriteLine("Goblin攻击");
//        }
//    }
//    #endregion
//    #region 练习题三
//    //FPS游戏模拟
//    //写一个玩家类，玩家可以拥有各种武器
//    //现在有四种武器，冲锋枪，散弹枪，手枪，匕首
//    //玩家默认拥有匕首
//    //请在玩家类中写一个方法，可以拾取不同的武器替换自己拥有的武器
//    class Weapon { }
//    //冲锋枪
//    class SubmachineGun : Weapon{}
//    //散弹枪
//    class ShotGun : Weapon {    }
//    //手枪
//    class Pistol : Weapon  { }
//    //匕首
//    class Dagger : Weapon   {   }
//    class Player
//    {
//        private Weapon _weapon;
//        public Player()
//        {
//            this._weapon = new Dagger();
//        }
//        public void PickUp(Weapon weapon)
//        {
//            this._weapon = weapon;
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("练习题");
//            Random r=new Random();
//            int randomNum;
//            Monster[] monsters = new Monster[10];
//            for(int i=0;i<10;++i)
//            {
//                randomNum = r.Next(0, 2);
//                if(randomNum == 0)
//                {
//                    monsters[i] = new Boss();
//                }
//                else
//                {
//                    monsters[i] = new Goblin();
//                }
//            }
//            //遍历10个怪物 执行对应方法
//            for (int i = 0; i < monsters.Length; i++)
//            {
//                if (monsters[i] is Boss)
//                {
//                    (monsters[i] as Boss).Skill();
//                }
//                else
//                {
//                    (monsters[i] as Goblin).Atk();
//                }
//            }
//            Player p = new Player();

//            SubmachineGun s = new SubmachineGun();
//            p.PickUp(s);

//            ShotGun sg = new ShotGun();
//            p.PickUp(sg);
//        }
//    }
//}
//namespace Lesson14_练习题
//{
//    #region 练习题
//    //有一个打工人基类，有工种，工作内容两个特征，一个工作方法
//    //程序员、策划、美术分别继承打工人
//    //请用继承中的构造函数这个知识点
//    //实例化3个对象，分别是程序员、策划、美术
//    class Worker
//    {
//        public string type;
//        public string content;
//        public Worker(string type, string content)
//        {
//            this.type = type;
//            this.content = content;
//        }
//        public void Work()
//        {
//            Console.WriteLine("Worker构造函数");
//        }
//    }
//    class Programmer : Worker
//    {
//        public Programmer() : base("程序员", "编程")
//        {

//        }
//    }

//    class Plan : Worker
//    {
//        public Plan() : base("策划", "设计游戏")
//        {

//        }
//    }

//    class Art : Worker
//    {
//        public Art() : base("美术", "画画")
//        {

//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("继承中的构造练习题");

//            Programmer p = new Programmer();
//            p.Work();

//            Plan p2 = new Plan();
//            p2.Work();

//            Art p3 = new Art();
//            p3.Work();
//        }
//    }
//}

//namespace Lession_多态
//{
//    class Staff
//    {
//        public virtual void PunchTheClock()
//        {
//            Console.WriteLine("Staff打卡");
//        }
//    }
//    class Manager : Staff
//    {
//        public override void PunchTheClock()
//        {
//            Console.WriteLine("Manager打卡");
//        }
//    }
//    class Programmer : Staff
//    {
//        public override void PunchTheClock()
//        {
//            Console.WriteLine("老子不打卡");
//        }
//    }
//}

using System;

//namespace Lesson19_练习题
//{
//    #region 练习题一
//    //人、汽车、房子都需要登记，人需要到派出所登记，汽车需要去车管所登记，房子需要去房管局登记
//    //使用接口实现登记方法
//    interface IRegister
//    {
//        void Register();
//    }

//    class Person : IRegister
//    {
//        public void Register()
//        {
//            Console.WriteLine("派出所登记");
//        }
//    }

//    class Car : IRegister
//    {
//        public void Register()
//        {
//            Console.WriteLine("车管所登记");
//        }
//    }

//    class Home : IRegister
//    {
//        public void Register()
//        {
//            Console.WriteLine("房管局登记");
//        }
//    }

//    #endregion

//    #region 练习题二
//    //麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅
//    //直升机和部分鸟能飞
//    //鸵鸟和企鹅不能飞
//    //企鹅和天鹅能游泳
//    //除直升机，其它都能走
//    //请用面向对象相关知识实现

//    abstract class Bird
//    {
//        public abstract void Walk();
//    }

//    interface IFly
//    {
//        void Fly();
//    }

//    interface ISwimming
//    {
//        void Swimming();
//    }

//    class Sparrow : Bird, IFly
//    {
//        public void Fly()
//        {

//        }

//        public override void Walk()
//        {

//        }
//    }

//    class Ostrich : Bird
//    {
//        public override void Walk()
//        {

//        }
//    }

//    class Penguin : Bird, ISwimming
//    {
//        public void Swimming()
//        {

//        }

//        public override void Walk()
//        {

//        }
//    }

//    class Parrot : Bird, IFly
//    {
//        public void Fly()
//        {

//        }

//        public override void Walk()
//        {

//        }
//    }

//    class Swan : Bird, IFly, ISwimming
//    {
//        public void Fly()
//        {

//        }

//        public void Swimming()
//        {

//        }

//        public override void Walk()
//        {

//        }
//    }

//    class Helicopter : IFly
//    {
//        public void Fly()
//        {

//        }
//    }
//    #endregion

//    #region 练习题三
//    //多态来模拟移动硬盘、U盘、MP3查到电脑上读取数据
//    //移动硬盘与U盘都属于存储设备
//    //MP3属于播放设备
//    //但他们都能插在电脑上传输数据
//    //电脑提供了一个USB接口
//    //请实现电脑的传输数据的功能

//    interface IUSB
//    {
//        void ReadData();
//    }

//    class StorageDevice : IUSB
//    {
//        public string name;
//        public StorageDevice(string name)
//        {
//            this.name = name;
//        }

//        public void ReadData()
//        {
//            Console.WriteLine("{0}传输数据", name);
//        }
//    }

//    class MP3 : IUSB
//    {
//        public void ReadData()
//        {
//            Console.WriteLine("MP3传输数据");
//        }
//    }

//    class Computer
//    {
//        public IUSB usb1; //这里不违反接口不能实例化的原则，因为这里还是类似父类的引用指向子类的对象
//    }

//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("接口练习题");

//            IRegister[] arr = new IRegister[] { new Person(), new Home(), new Car() };

//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i].Register();
//            }

//            StorageDevice hd = new StorageDevice("移动硬盘");
//            StorageDevice ud = new StorageDevice("U盘");
//            MP3 mp3 = new MP3();

//            Computer c = new Computer();

//            c.usb1 = hd;
//            c.usb1.ReadData();

//            c.usb1 = ud;
//            c.usb1.ReadData();

//            c.usb1 = mp3;
//            c.usb1.ReadData();

//        }
//    }
//}
using System;

//namespace Lesson22_练习题
//{
//    #region 练习题一
//    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
//    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX”XX为具体内容

//    class Player
//    {
//        private string name;
//        private int hp;
//        private int atk;
//        private int def;
//        private int miss;

//        public Player(string name, int hp, int atk, int def, int miss)
//        {
//            this.name = name;
//            this.hp = hp;
//            this.atk = atk;
//            this.def = def;
//            this.miss = miss;
//        }

//        public override string ToString()
//        {
//            return string.Format("玩家{0},血量{1},攻击力{2},防御力{3},闪避{4}", name, hp, atk, def, miss);
//        }
//    }
//    #endregion

//    #region 练习题二
//    //一个Monster类的引用对象A，Monster类有 攻击力、防御力、血量、技能ID等属性。
//    //我想复制一个和A对象一模一样的B对象。并且改变了B的属性，A不会受到影响。请问如何实现？

//    class Monster
//    {
//        public Monster(int atk, int def, int hp, int skillID)
//        {
//            Atk = atk;
//            Def = def;
//            Hp = hp;
//            SkillID = skillID;
//        }

//        public int Atk
//        {
//            get;
//            set;
//        }

//        public int Def
//        {
//            get;
//            set;
//        }
//        public int Hp
//        {
//            get;
//            set;
//        }
//        public int SkillID
//        {
//            get;
//            set;
//        }

//        public Monster Clone()
//        {
//            return MemberwiseClone() as Monster;
//        }

//        public override string ToString()
//        {
//            return string.Format("攻击里{0},防御力{1},血量{2},技能{3}", Atk, Def, Hp, SkillID);
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("万物之父中的方法");

//            Player p = new Player("唐老狮", 100, 10, 5, 20);
//            Console.WriteLine(p);

//            Monster m = new Monster(10, 20, 100, 1);
//            Monster m2 = m.Clone();
//            m2.Atk = 30;
//            m2.SkillID = 100;
//            Console.WriteLine(m);
//            Console.WriteLine(m2);
//        }
//    }
//}

using System;

//namespace Lesson24_练习题
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("string和StringBuilder");
//            #region 练习题一 请描述string和stringbuilder的区别
//            //1.string相对stringbuilder 更容易产生垃圾 每次修改拼接都会产生垃圾
//            //2.string相对stringbuilder 更加灵活 因为它提供了更多的方法供使用
//            //如何选择他们两
//            //需要频繁修改拼接的字符串可以使用stringbuilder
//            //需要使用string独特的一些方法来处理一些特殊逻辑时可以使用string
//            #endregion
//        }
//    }
//}

using System;

namespace Lesson25_面向对象相关_结构体和类的区别
{
    struct p
    {
        public int x;
        public int y;
        public p(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public p()
        {
            this.x = 0;
            this.y = 0;
        }
        //~p()
        //{
        //    Console.WriteLine("析构函数");
        //}
    }
    static class P_
    {
        public static int x=0;
        public static int y;
    }
    class p__
    {
        public p__ p;
        public p__(int x, int y)
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体和类的区别");

            #region 区别概述
            //结构体和类最大的区别是在存储空间上的，因为结构体是值，类是引用，
            //因此他们的存储位置一个在栈上，一个在堆上，
            //通过之前知识点的学习，我相信你能够从此处看出他们在使用的区别——值和引用对象在赋值时的区别。

            //结构体和类在使用上很类似，结构体甚至可以用面向对象的思想来形容一类对象。
            //结构体具备着面向对象思想中封装的特性，但是它不具备继承和多态的特性，因此大大减少了它的使用频率。
            //由于结构体不具备继承的特性，所以它不能够使用protected保护访问修饰符。
            #endregion

            #region 细节区别
            //1.结构体是值类型，类是引用类型
            //2.结构体存在栈中，类存在堆中
            //3.结构体成员不能使用protected访问修饰符，而类可以
            //4.结构体成员变量申明不能指定初始值，而类可以
            //5.结构体不能申明无参的构造函数，而类可以
            //6.结构体申明有参构造函数后，无参构造不会被顶掉
            //7.结构体不能申明析构函数，而类可以
            //8.结构体不能被继承，而类可以
            //9.结构体需要在构造函数中初始化所有成员变量，而类随意
            //10.结构体不能被静态static修饰（不存在静态结构体），而类可以
            //11.结构体不能在自己内部申明和自已一样的结构体变量，而类可以
            #endregion

            #region 结构体的特别之处
            //结构体可以继承 接口 因为接口是行为的抽象
            #endregion

            #region 如何选择结构体和类
            //1.想要用继承和多态时，直接淘汰结构体，比如玩家、怪物等等
            //2.对象是数据集合时，优先考虑结构体，比如位置、坐标等等
            //3.从值类型和引用类型赋值时的区别上去考虑，比如经常被赋值传递的对象，并且
            //改变赋值对象，原对象不想跟着变化时，就用结构体。比如坐标、向量、旋转等等
            #endregion
        }
    }
}
