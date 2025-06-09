using System;
using System.Collections;
using System.Runtime.InteropServices;

//namespace Lesson1_练习题
//{
//    #region 练习题一
//    //请简述ArrayList和数组的区别
//    #region 答案
//    //ArrayList本质上是一个object数组的封装

//    //1.ArrayList可以不用一开始就定长，单独使用数组是定长的
//    //2.数组可以指定存储类型，ArrayList默认为object类型
//    //3.数组的增删需要我们自己去实现，ArrayList帮我们封装了方便的API来使用
//    //4.ArrayList使用时可能存在装箱拆箱，数组使用时只要不是object数组那就不存在这个问题
//    //5.数组长度为Length, ArrayList长度为Count
//    #endregion
//    #endregion

//    #region 练习题二
//    //创建一个背包管理类，使用ArrayList存储物品，
//    //实现购买物品，卖出物品，显示物品的功能。购买与卖出物品会导致金钱变化

//    class BagMgr
//    {
//        //背包中的物品
//        private ArrayList items;

//        private int money;

//        public BagMgr(int money)
//        {
//            this.money = money;
//            items = new ArrayList();
//        }

//        public void BuyItem(Item item)
//        {
//            if (item.num <= 0 || item.money < 0)
//            {
//                Console.WriteLine("请传入正确的物品信息");
//                return;
//            }

//            if (this.money < item.money * item.num)
//            {
//                //买不起 钱不够
//                Console.WriteLine("买不起 钱不够");
//                return;
//            }
//            //减钱
//            this.money -= item.money * item.num;
//            Console.WriteLine("购买{0}{1}个花费{2}钱", item.name, item.num, item.money * item.num);
//            Console.WriteLine("剩余{0}元钱", this.money);
//            //如果想要叠加物品 可以在前面先判断 是否有这个物品 然后加数量
//            for (int i = 0; i < items.Count; i++)
//            {
//                if ((items[i] as Item).id == item.id)
//                {
//                    //叠加数量
//                    (items[i] as Item).num += item.num;
//                    return;
//                }
//            }
//            //把一组物品加到 list中
//            items.Add(item);
//        }

//        public void SellItem(Item item)
//        {
//            for (int i = 0; i < items.Count; i++)
//            {
//                //如何判断 卖的东西我有没有
//                //这是在判断 两个引用地址 指向的是不是同一个房间
//                //所以我们要判断 卖的物品 一般不这样判断
//                //if(items[i] == item)
//                //{

//                //}
//                if ((items[i] as Item).id == item.id)
//                {
//                    //两种情况
//                    int num = 0;
//                    string name = (items[i] as Item).name;
//                    int money = (items[i] as Item).money;
//                    if ((items[i] as Item).num > item.num)
//                    {
//                        //1.比我身上的少
//                        num = item.num;
//                    }
//                    else
//                    {
//                        //2.大于等于我身上的东西数量
//                        num = (items[i] as Item).num;
//                        //卖完了  就从身上移除了
//                        items.RemoveAt(i);
//                    }

//                    int sellMoney = (int)(num * money * 0.8f);
//                    this.money += sellMoney;

//                    Console.WriteLine("卖了{0}{1}个，赚了{2}钱", name, num, sellMoney);
//                    Console.WriteLine("目前拥有{0}元钱", this.money);

//                    return;
//                }
//            }
//        }

//        public void SellItem(int id, int num = 1)
//        {
//            //我这是想 直接调用上面写好的方法 
//            //我就直接构造一个Item类 把ID和数量两个关键信息设置了即可 就可以卖了
//            Item item = new Item(id, num);
//            SellItem(item);
//        }

//        public void ShowItem()
//        {
//            Item item;
//            for (int i = 0; i < items.Count; i++)
//            {
//                item = items[i] as Item;
//                Console.WriteLine("有{0}{1}个", item.name, item.num);
//            }
//            Console.WriteLine("当前拥有{0}元钱", this.money);
//        }
//    }

//    class Item
//    {
//        //物品唯一ID 来区分物品的种类
//        public int id;
//        //物品多少钱(单价)
//        public int money;
//        //物品名字
//        public string name;
//        //public string tips;
//        //物品数量
//        public int num;

//        public Item(int id, int num)
//        {
//            this.id = id;
//            this.num = num;
//        }

//        public Item(int id, int money, string name, int num)
//        {
//            this.id = id;
//            this.money = money;
//            this.name = name;
//            this.num = num;
//        }
//    }

//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ArrayList练习题");

//            BagMgr bag = new BagMgr(99999);
//            Item i1 = new Item(1, 10, "红药", 10);
//            Item i2 = new Item(2, 20, "蓝药", 10);
//            Item i3 = new Item(3, 999, "屠龙刀", 1);

//            bag.BuyItem(i1);
//            bag.BuyItem(i2);
//            bag.BuyItem(i3);

//            bag.SellItem(i3);
//            bag.SellItem(1, 1);
//            bag.SellItem(1, 1);
//            bag.SellItem(2, 1);
//            bag.SellItem(2, 1);
//        }
//    }
//}


//namespace Lesson2_Stack
//{
//    class Test
//    {

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stack");
//            #region 知识点一 Stack的本质
//            //Stack（栈）是一个C#为我们封装好的类
//            //它的本质也是object[]数组，只是封装了特殊的存储规则

//            //Stack是栈存储容器，栈是一种先进后出的数据结构
//            //先存入的数据后获取，后存入的数据先获取
//            //栈是先进后出
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间 System.Collections
//            Stack stack = new Stack();
//            #endregion

//            #region 知识点三 增取查改

//            #region 增
//            //压栈
//            stack.Push(1);
//            stack.Push("123");
//            stack.Push(true);
//            stack.Push(1.2f);
//            stack.Push(new Test());

//            #endregion

//            #region 取
//            //栈中不存在删除的概念
//            //只有取的概念
//            //弹栈
//            object v = stack.Pop();
//            Console.WriteLine(v);

//            v = stack.Pop();
//            Console.WriteLine(v);
//            #endregion

//            #region 查
//            //1.栈无法查看指定位置的 元素
//            //  只能查看栈顶的内容
//            v = stack.Peek();
//            Console.WriteLine(v);
//            v = stack.Peek();
//            Console.WriteLine(v);

//            //2.查看元素是否存在于栈中
//            if (stack.Contains("123"))
//            {
//                Console.WriteLine("存在123");
//            }
//            if(stack.Contains("1234"))
//            {
//                Console.WriteLine("cunz");
//            }

//            #endregion

//            #region 改
//            //栈无法改变其中的元素 只能压(存)和弹（取）
//            //实在要改 只有清空
//            stack.Clear();
//            Console.WriteLine(stack.Count);
//            stack.Push("1");
//            stack.Push(2);
//            stack.Push("哈哈哈");
//            #endregion

//            #endregion

//            #region 知识点四 遍历
//            //1.长度
//            Console.WriteLine(stack.Count);

//            //2.用foreach遍历
//            //  而且遍历出来的顺序 也是从栈顶到栈底
//            foreach(object item in stack)
//            {
//                Console.WriteLine(item);
//            }

//            //3.还有一种遍历方式
//            //  将栈转换为object数组
//            //  遍历出来的顺序 也是从栈顶到栈底
//            object[] array = stack.ToArray();
//            object[] array2 = stack.ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine(array[i]);
//            }

//            Console.WriteLine(stack.Count);
//            //4.循环弹栈
//            while (stack.Count > 0)
//            {
//                object o = stack.Pop();
//                Console.WriteLine(o);
//            }
//            Console.WriteLine(stack.Count);
//            #endregion

//            #region 知识点五 装箱拆箱
//            //由于用万物之父来存储数据，自然存在装箱拆箱。
//            //当往其中进行值类型存储时就是在装箱
//            //当将值类型对象取出来转换使用时，就存在拆箱。
//            #endregion
//        }
//    }
//}

//namespace test_queue
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //使用队列存储消息，一次性存10条消息，每隔一段时间打印一条消息
//            //控制台打印消息时要有明显停顿感
//            Queue queue = new Queue();
//            queue.Enqueue("获得10枚金币");
//            queue.Enqueue("获得屠龙刀x1");
//            queue.Enqueue("获得99枚金币");
//            queue.Enqueue("获得血瓶x1");
//            queue.Enqueue("获得85枚金币");
//            queue.Enqueue("获得11枚金币");
//            queue.Enqueue("获得2枚金币");
//            queue.Enqueue("获得91枚金币");
//            queue.Enqueue("获得73枚金币");
//            queue.Enqueue("获得645枚金币");

//            int updateIndex = 1;
//            while(true)
//            {
//                if(updateIndex %99999999 ==0)
//                {
//                    if ((queue.Count>0))
//                    {
//                        Console.WriteLine(queue.Dequeue());
//                    }
//                    updateIndex = 0;
//                }
//                ++updateIndex;
//            }
//        }
//    }
//}
//namespace Hashtable_test
//{

//    class Monster
//    {
//        public int id;

//        public Monster(int id)
//        {
//            this.id = id;
//        }

//        public void Dead()
//        {
//            Console.WriteLine("怪物{0}死亡", id);
//        }
//    }
//    class MonsterMgr
//    {
//        private static MonsterMgr instance = new MonsterMgr();
//        private Hashtable monstersTable = new Hashtable();
//        private MonsterMgr()
//        {
//        }
//        public static MonsterMgr Instance
//        {
//            get
//            {
//                return instance;
//            }
//        }
//        private int monsterID = 0;
//        public void AddMonster()
//        {
//            Monster monster = new Monster(monsterID);
//            Console.WriteLine("创建了id为{0}的怪物", monsterID);
//            ++monsterID;
//            //Hashtable 的键 是不能重复的 所以一定是用唯一ID
//            monstersTable.Add(monster.id, monster);
//        }

//        public void RemoveMonster(int monsterID)
//        {
//            if (monstersTable.ContainsKey(monsterID))
//            {
//                (monstersTable[monsterID] as Monster).Dead();
//                monstersTable.Remove(monsterID);
//            }
//        }
//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hashtable练习题");

//            MonsterMgr.Instance.AddMonster();
//            MonsterMgr.Instance.AddMonster();
//            MonsterMgr.Instance.AddMonster();
//            MonsterMgr.Instance.AddMonster();
//            MonsterMgr.Instance.AddMonster();
//            MonsterMgr.Instance.AddMonster();

//            MonsterMgr.Instance.RemoveMonster(0);
//            MonsterMgr.Instance.RemoveMonster(3);
//        }
//    }

//}

using System;
using System.Linq.Expressions;

//namespace Lesson5_泛型
//{
//    #region 知识点一 泛型是什么
//    //泛型实现了类型参数化，达到代码重用目的
//    //通过类型参数化来实现同一份代码上操作多种类型

//    //泛型相当于类型占位符
//    //定义类或方法时使用替代符代表变量类型
//    //当真正使用类或者方法时再具体指定类型
//    #endregion

//    #region 知识点二 泛型分类
//    //泛型类和泛型接口
//    //基本语法：
//    //class 类名<泛型占位字母>
//    //interface 接口名<泛型占位字母>

//    //泛型函数
//    //基本语法：函数名<泛型占位字母>(参数列表)

//    //注意：泛型占位字母可以有多个，用逗号分开
//    #endregion

//    #region 知识点三 泛型类和接口

//    class TestClass<T>
//    {
//        public T value;
//    }

//    class TestClass2<T1, T2, K, M, LL, Key, Value>
//    {
//        public T1 value1;
//        public T2 value2;
//        public K value3;
//        public M value4;
//        public LL value5;
//        public Key value6;
//        public Value value7;
//    }

//    interface TestInterface<T>
//    {
//        T Value
//        {
//            get;
//            set;
//        }
//    }

//    //class Test : TestInterface<int>
//    //{
//    //    public int Value
//    //    {
//    //        get;
//    //        set;
//    //    }
//    //}

//    class Test : TestInterface<int>
//    {
//        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    }

//    #endregion

//    #region 知识点四 泛型方法
//    //1.普通类中的泛型方法

//    class Test2
//    {
//        public void TestFun<T>(T value)
//        {
//            Console.WriteLine(value);
//        }

//        public void TestFun<T>()
//        {
//            //用泛型类型 在里面做一些逻辑处理
//            T t = default(T);
//        }

//        public T TestFun<T>(string v)
//        {
//            return default(T);
//        }

//        public void TestFun<T, K, M>(T t, K k, M m)
//        {

//        }
//    }

//    //2.泛型类中的泛型方法
//    class Test2<T>
//    {
//        public T value;

//        public void TestFun<K>(K k)
//        {
//            Console.WriteLine(k);
//        }

//        //这个不叫泛型方法 因为 T是泛型类申明的时候 就指定 在使用这个函数的时候 
//        //我们不能再去动态的变化了
//        public void TestFun(T t)
//        {

//        }
//    }

//    #endregion

//    #region 知识点五 泛型的作用
//    //1.不同类型对象的相同逻辑处理就可以选择泛型
//    //2.使用泛型可以一定程度避免装箱拆箱
//    //举例：优化ArrayList
//    class ArrayList<T>
//    {
//        private T[] array;

//        public void Add(T value)
//        {

//        }

//        public void Remove(T value)
//        {

//        }
//    }
//    #endregion

//    #region 总结
//    //1.申明泛型时 它只是一个类型的占位符
//    //2.泛型真正起作用的时候 是在使用它的时候
//    //3.泛型占位字母可以有n个用逗号分开
//    //4.泛型占位字母一般是大写字母
//    //5.不确定泛型类型时 获取默认值 可以使用default(占位字符)
//    //6.看到<>包裹的字母 那肯定是泛型
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("泛型");

//            TestClass<int> t = new TestClass<int>();
//            t.value = 10;
//            Console.WriteLine(t.value);

//            TestClass<string> t2 = new TestClass<string>();
//            t2.value = "123123";
//            Console.WriteLine(t2.value);

//            TestClass2<int, string, float, double, TestClass<int>, uint, short> t3 = new TestClass2<int, string, float, double, TestClass<int>, uint, short>();

//            Test2 tt = new Test2();
//            tt.TestFun<string>("123123");

//            Test2<int> tt2 = new Test2<int>();
//            tt2.TestFun(10);
//            tt2.TestFun<string>("123");
//            tt2.TestFun<float>(1.2f);
//            tt2.TestFun(20);
//            tt2.TestFun<float>(1.3f);
//        }

//        static string Fun<T>(T t)
//        {
//            if(typeof(T)==typeof(int))
//            {
//                return string.Format("{0},{1}字节", "整形", sizeof(int));
//            }
//            else if (typeof(T) == typeof(char))
//            {
//                return string.Format("{0},{1}字节", "字符", sizeof(char));
//            }
//            else if (typeof(T) == typeof(float))
//            {
//                return string.Format("{0},{1}字节", "单精度浮点数", sizeof(float));
//            }
//            else if (typeof(T) == typeof(string))
//            {
//                return string.Format("{0},{1}字节", "字符串", "?");
//            }
//            return "其它类型";
//        }
//    }
//}

//namespace LessON6_test
//{
//    #region 泛型实现单例模式基类
//    //泛型实现单例模式基类
//    class SingleBase<T> where T : new()
//    {
//        private static T instance = new T();
//        public static T Instance
//        {
//            get { return instance;
//            }
//            //set { }
//        }
//    }
//    class GameMgr : SingleBase<GameMgr>
//    {
//        public int value = 10;
//    }

//    class Test : SingleBase<Test>
//    {
//        public int value = 10;
//    }

//    class Test2
//    {
//        private static Test2 instance = new Test2();
//        public static Test2 Instance
//        {
//            get { return instance;
//            }
//        }
//        private Test2()
//        {
//            Console.WriteLine("创建了Test2");
//        }
//        public int value = 10;
//    }
//    #endregion

//    #region  利用泛型知识点，仿造ArrayList实现一个不确定数组类型的类
//    //实现增删查改方法
//    class  ArrayList<T>
//    {
//        private T[] array;
//        private int count;
//        private int capacity;
//        public ArrayList()
//        {
//            count = 0;
//            capacity = 16;
//            array = new T[capacity];
//        }
//        public void Add(T value)
//        {
//            if(count >=capacity)
//            {
//                T[] newArray = new T[capacity * 2];
//                capacity *= 2;
//                for (int i=0;i<count; i++)
//                {
//                    newArray[i] = array[i];
//                }
//                array= newArray; 
//            }
//            array[count++] = value;
//        }
//        public void Remove(T value)
//        {
//            int index = -1;
//            for (int i = 0; (i) < count; (i)++)
//            {
//                if(array[i].Equals(value))
//                {
//                    index = i;
//                    break;
//                }
//            }
//            if (index != -1)
//            {
//                RemoveAt(index);
//            }
//        }
//        public void RemoveAt(int index)
//        {
//            if (index < 0 || index >= count)
//            {
//                Console.WriteLine("索引越界");
//                return;
//            }
//            for (int i = index; i < count - 1; i++)
//            {
//                array[i] = array[i + 1];
//            }
//            array[count-1] = default(T);
//            count--;
//        }
//        public T this[int index]
//        {
//            get 
//            {
//                if(index <0 || index >=count)
//                {
//                    Console.WriteLine("索引越界");
//                    return default(T);
//                }
//                return array[index];
//            }
//            set 
//            {
//                if (index < 0 || index >= count)
//                {
//                    Console.WriteLine("索引不合法");
//                    return;
//                }
//                array[index] = value;
//            }
//        }

//        public int Capacity
//        {
//            get { return this.capacity; }
//        }
//        public int Count
//        {
//            get
//            {
//                return count;
//            }
//        }
//    }
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("泛型约束练习题");

//            Test.Instance.value = 10;

//            //Test t = new Test();
//            Test2.Instance.value = 10;
//            GameMgr.Instance.value = 10;

//            //GameMgr g = new GameMgr();

//            ArrayList<int> array = new ArrayList<int>();
//            Console.WriteLine(array.Count);
//            Console.WriteLine(array.Capacity);
//            array.Add(1);
//            array.Add(2);
//            array.Add(3);
//            Console.WriteLine(array.Count);
//            Console.WriteLine(array.Capacity);

//            Console.WriteLine(array[1]);
//            Console.WriteLine(array[-1]);
//            Console.WriteLine(array[3]);

//            array.RemoveAt(0);
//            Console.WriteLine(array.Count);
//            for (int i = 0; i < array.Count; i++)
//            {
//                Console.WriteLine(array[i]);
//            }

//            Console.WriteLine(array[0]);
//            array[0] = 99;
//            Console.WriteLine(array[0]);

//            ArrayList<string> array2 = new ArrayList<string>();
//        }
//    }

//}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//namespace Lesson7_练习题
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("List练习题");

//            #region 练习题一
//            //请描述List和ArrayList的区别
//            //List内部封装的是一个泛型数组
//            //ArrayList内部封装的是一个object数组
//            #endregion

//            #region 练习题二
//            //建立一个整形List，为它添加10~1
//            //删除List中第五个元素
//            //遍历剩余元素并打印

//            List<int> list = new List<int>();
//            for (int i = 10; i > 0; i--)
//            {
//                list.Add(i);
//            }
//            list.RemoveAt(4);
//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }
//            #endregion

//            #region 练习题三
//            //一个Monster基类，Boss和Gablin类继承它。
//            //在怪物类的构造函数中，将其存储到一个怪物List中
//            //遍历列表可以让Boss和Gablin对象产生不同攻击

//            Boss b = new Boss();
//            Gablin g = new Gablin();
//            Boss b2 = new Boss();
//            Gablin g2 = new Gablin();

//            for (int i = 0; i < Monster.monsters.Count; i++)
//            {
//                Monster.monsters[i].Atk();
//            }
//            #endregion
//        }
//    }

//    abstract class Monster
//    {
//        public static List<Monster> monsters = new List<Monster>();
//        public Monster()
//        {
//            monsters.Add(this);
//        }

//        public abstract void Atk();
//    }

//    class Gablin : Monster
//    {
//        public override void Atk()
//        {
//            Console.WriteLine("哥布林的攻击");
//        }
//    }

//    class Boss : Monster
//    {
//        public override void Atk()
//        {
//            Console.WriteLine("Boss的攻击");
//        }
//    }
//}


//namespace 练习题8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Dictionary练习题");
//            #region 练习题一 
//            //使用字典存储0~9的数字对应的大写文字
//            //提示用户输入一个不超过三位的数，提供一个方法，返回数的大写
//            //例如：306，返回叁零陆
//            try
//            {
//                Console.WriteLine("请输入一个不超过3位的数");
//                Console.WriteLine(GetInfoo(int.Parse(Console.ReadLine())));
//            }
//            catch
//            {
//                Console.WriteLine("请输入数字");
//            }
//            #endregion
//        }

//        static string GetInfoo(int num)
//        {
//            Dictionary<int, string> dic = new Dictionary<int, string>();
//            dic.Add(0, "零");
//            dic.Add(1, "壹");
//            dic.Add(2, "贰");
//            dic.Add(3, "叁");
//            dic.Add(4, "肆");
//            dic.Add(5, "伍");
//            dic.Add(6, "陆");
//            dic.Add(7, "柒");
//            dic.Add(8, "捌");
//            dic.Add(9, "玖");
//            string str = "";
//            //得百位
//            int b = num / 100;
//            if (b != 0)
//            {
//                str += dic[b];
//            }
//            //得十位数
//            int s = num % 100 / 10;
//            if (s != 0 || str != "")
//            {
//                str += dic[s];
//            }
//            //得个位
//            int g = num % 10;
//            str += dic[g];
//            return str;
//        }
//    }
//}

//namespace 练习题9
//{
//    class LinkedList<T>
//    {
//        private LinkedNode<T> head;
//        private LinkedNode<T> last;
//        private int count = 0;
//        public int Count
//        {
//            get
//            {
//                return this.count;
//            }
//        }
//        public LinkedNode<T> Head
//        {
//            get { return this.head; }
//        }
//        public LinkedNode<T> Last
//        {
//            get { return this.last; }
//        }
//        public void Add(T value)
//        {
//            LinkedNode<T> new_noed= new LinkedNode<T>(value);
//            if(head == null)
//            {
//                head = new_noed;
//                last = new_noed;
//            }
//            else
//            {
//                last.nextNode = new_noed;
//                new_noed.frontNode = last;
//                last = new_noed;
//            }
//            ++count;
//        }
//        public void RemoveAt(int index)
//        {
//            LinkedNode<T> temp_node=head;
//            if(index < 0 || index >=count)
//            {
//                Console.WriteLine("索引越界");
//                return;
//            }
//            int temp_count = 0;
//            while(true)
//            {
//                if(temp_count==index)
//                {
//                    if (temp_node.frontNode != null )
//                    {
//                        temp_node.frontNode.nextNode = temp_node.nextNode;
//                    }
//                    if (temp_node.nextNode!=null)
//                    {
//                        temp_node.nextNode.frontNode = temp_node.frontNode;
//                    }

//                    if(index==0)
//                    {
//                        head=temp_node.nextNode;
//                    }
//                    else if(index == count - 1)
//                    {
//                        last = temp_node.frontNode;
//                    }
//                    --count;
//                    break;
//                }
//                temp_node = temp_node.nextNode;
//                ++temp_count;
//            }
//        }
//    }
//    class LinkedNode<T>
//    {
//        public T value;
//        public LinkedNode<T> nextNode;
//        public LinkedNode<T> frontNode;
//        public LinkedNode(T value)
//        {
//            this.value = value;
//            nextNode = null;
//            frontNode = null;
//        }
//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            LinkedList<int> link = new LinkedList<int>();
//            link.Add(1);
//            link.Add(2);
//            link.Add(3);
//            link.Add(4);
//            //正向遍历
//            LinkedNode<int> node = link.Head;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.nextNode;
//            }
//            //反向遍历
//            node = link.Last;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.frontNode;
//            }
//            link.RemoveAt(0);
//            //正向遍历
//            node = link.Head;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.nextNode;
//            }
//            //反向遍历
//            node = link.Last;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.frontNode;
//            }
//            Console.WriteLine("***************");
//            link.RemoveAt(1);
//            //正向遍历
//            node = link.Head;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.nextNode;
//            }
//            //反向遍历
//            node = link.Last;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.frontNode;
//            }
//            Console.WriteLine("***************");
//            link.RemoveAt(1);
//            //正向遍历
//            node = link.Head;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.nextNode;
//            }
//            //反向遍历
//            node = link.Last;
//            while (node != null)
//            {
//                Console.WriteLine(node.value);
//                node = node.frontNode;
//            }
//            Console.WriteLine("***************");
//            link.RemoveAt(1);
//        }
//    }
//}

//namespace Lesson10_练习题
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            LinkedList<int> list_= new LinkedList<int>();
//            Random random = new Random();
//            for(int i=0;i<10;++i)
//            {
//                list_.AddLast(random.Next(1, 100));
//            }
//            foreach(int item in list_)
//            {
//                Console.WriteLine(item);
//            }
//            LinkedListNode<int> node = list_.Last;
//            while (node!=null)
//            {
//                Console.WriteLine(node.Value);
//                node = node.Previous;
//            }
//        }

//    }
//}

//namespace lesson_12
//{
//    abstract class Person
//    {
//        abstract public void eat();
//    }
//    class ma : Person
//    {
//        public override void eat()
//        {
//            Console.WriteLine("妈妈吃饭");
//        }

//        public void dofood()
//        {
//            Console.WriteLine("妈妈做饭");

//            //this.begin_eat+= 
//            Console.WriteLine("饭做好了");
//            if (begin_eat!=null)
//            {
//                this.begin_eat();
//            }
//        }

//        public Action begin_eat;
//    }

//    class ba : Person
//    {
//        public override void eat()
//        {
//            Console.WriteLine("老爸吃饭");
//        }
//    }

//    class son:Person
//    {
//        public override void eat()
//        {
//            Console.WriteLine("son吃饭");
//        }
//    }

//    class Monster
//    {
//        public Action<Monster> dosomething;
//        public int a = 10;
//        public void Dead() { 
//            if(dosomething!=null)
//            {
//                this.dosomething(this);
//                dosomething = null;
//            }
//        }
//    }
//    class player {
//        private int money = 0;
//        public void monsterdead(Monster m)
//        {
//            this.money += m.a;
//            Console.WriteLine("现在有多{0}钱：", this.money);
//        }
//    }
//    class panel {
//        private int nowshowMoney = 0;
//        public void monsterdead(Monster m)
//        {
//            nowshowMoney += m.a;

//            Console.WriteLine("死了怪 ，前发生变化 {0}",nowshowMoney);
//        }
//    }

//    class CJ
//    {
//        private int nowkillnum = 0;
//        public void monsterdead(Monster m)
//        {
//            nowkillnum++;
//            Console.WriteLine("当前杀了{0}个怪", nowkillnum);
//        }
//    }



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ma mother=new ma();
//            ba father = new ba();
//            son errzi = new son();

//            mother.begin_eat += father.eat;
//            mother.begin_eat += mother.eat;
//            mother.begin_eat += errzi.eat;
//            mother.dofood();

//            Monster m1 = new Monster();
//            player play = new player();
//            panel p = new panel();
//            CJ c = new CJ();
//            m1.dosomething += play.monsterdead;
//            m1.dosomething += p.monsterdead;
//            m1.dosomething += c.monsterdead;
//            m1.Dead();
//            m1.Dead();
//        }
//    }

//}

//namespace lianxi_13
//{
//    #region 练习题
//    //有一个热水器，包含一个加热器，一个报警器，一个显示器
//    //我们给热水器通上电，当水温超过95度时
//    //1.报警器会开始发出语音，告诉你水的温度
//    //2.显示器也会改变水温提示，提示水已经烧开了
//    class Heater
//    {
//        public event Action<int> myEvnet;
//        private int value = 0;
//        public void AddHot()
//        {
//            int updateIndex = 0;
//            while(true)
//            {
//                if(updateIndex % 9999999 == 0)
//                {
//                    ++value;
//                    Console.WriteLine("加热到了{0}度", value);
//                    if(value>=100)
//                    {
//                        break;
//                    }
//                    if(value>=95)
//                    {
//                        if(myEvnet != null)
//                        {
//                            myEvnet(value);
//                        }
//                        myEvnet = null;
//                    }
//                    updateIndex = 0;
//                }
//                updateIndex++;
//            }
//        }
//    }

//    class Alarm
//    {
//        public void ShowInfo(int v)
//        {
//            Console.WriteLine("wendu{0}", v);
//        }
//    }

//    class Display
//    {
//        public void ShowInfo(int v)
//        {
//            Console.WriteLine("水开了，当前水温{0}度", v);
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("事件练习题");

//            Heater h = new Heater();
//            Alarm a = new Alarm();
//            Display d = new Display();
//            h.myEvnet += a.ShowInfo;
//            h.myEvnet += d.ShowInfo;
//            //加热
//            h.AddHot();
//        }
//    }
//    #endregion
//}

//namespace lesson_014
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("匿名函数练习题");
//            Func<int, int> fun = TestFun(2);
//            Console.WriteLine(fun(3));
//        }

//        static Func<int,int> TestFun(int i)
//        {
//            return delegate (int v)
//            {
//                return i * v;
//            };
//        }
//    }
//}

//namespace Lesson_15
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("lambad表达式 练习题");
//            GetFun()();
//            GetFun2()();
//            //GetFun3()();
//        }

//        static Action GetFun()
//        {
//            Action action = null;
//            for(int i=1;i<=10;++i)
//            {
//                int index = i;
//                action += () => { Console.WriteLine(index); };
//            }
//            return action;
//        }

//        static Action GetFun2()
//        {
//            Action action = null;
//            for (int i = 1; i <= 10; i++)
//            {
//                int index = i;
//                action += delegate ()
//                {
//                    Console.WriteLine(index);
//                };
//            }
//            return action;
//        }

//        static Action GetFun3()
//        {
//            Action action = null;
//            for (int i = 1; i <= 10; i++)
//            {
//                int index = i;
//                action += () =>
//                {
//                    Show(index);
//                };
//            }
//            return action;
//        }

//        static void Show(int i)
//        {
//            Console.WriteLine(i);
//        }

//    }
//}

//namespace lessom15
//{
//    class Monster
//    {
//        public static int SortType = 1;
//        public int hp;
//        public int atk;
//        public int def;
//        public Monster(int hp, int atk, int def)
//        {
//            this.hp = hp;
//            this.atk = atk;
//            this.def = def;
//        }
//        public override string ToString()
//        {
//            return string.Format("怪物信息-血量{0}攻击力{1}防御力{2}", this.hp, this.atk, this.def);
//        }
//    }


//    class Item
//    {
//        public int type;
//        public string name;
//        public int quality;

//        public Item(int type, string name, int quality)
//        {
//            this.type = type;
//            this.name = name;
//            this.quality = quality;
//        }

//        public override string ToString()
//        {
//            return string.Format("道具信息-类型{0} 名字{1} 品质{2}", type, name, quality);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Monster> monsters = new List<Monster>();
//            Random r = new Random();
//            for (int i = 0; i < 10; i++)
//            {
//                monsters.Add(new Monster(r.Next(100, 201), r.Next(5, 21), r.Next(2, 10)));
//                Console.WriteLine(monsters[i]);
//            }

//            Console.WriteLine("********************");
//            try
//            {
//                Console.WriteLine("请输入1~4的数字进行排序");
//                Console.WriteLine("1:按攻击力升序排列");
//                Console.WriteLine("2:按防御力升序排列");
//                Console.WriteLine("3:按血量序排列");
//                Console.WriteLine("4:翻转");
//                Monster.SortType = int.Parse(Console.ReadLine());
//                if(Monster.SortType ==4)
//                {
//                    monsters.Reverse();
//                }
//                else
//                {
//                    monsters.Sort(SortFun);
//                }

//                switch (Monster.SortType)
//                {
//                    case 1:
//                        monsters.Sort((a, b) =>
//                        {
//                            return a.atk > b.atk ? 1 : -1;
//                        });
//                        break;
//                    case 2:
//                        monsters.Sort((a, b) =>
//                        {
//                            return a.def > b.def ? 1 : -1;
//                        });
//                        break;
//                    case 3:
//                        monsters.Sort((a, b) =>
//                        {
//                            return a.hp > b.hp ? 1 : -1;
//                        });
//                        break;
//                    case 4:
//                        //翻转API
//                        monsters.Reverse();
//                        break;
//                }

//                for (int i = 0; i < 10; i++)
//                {
//                    Console.WriteLine(monsters[i]);
//                }
//            }
//            catch
//            {
//                Console.WriteLine("请输入数字");
//            }

//            List<Item> itemList = new List<Item>();
//            Random r1 = new Random();
//            for (int i = 0; i < 10; i++)
//            {
//                itemList.Add(new Item(r1.Next(1, 6), "Item" + r1.Next(1, 200), r1.Next(1, 6)));
//                Console.WriteLine(itemList[i]);
//            }

//            itemList.Sort((Item a, Item b) =>
//            {
//                if (a.type != b.type)
//                {
//                    return a.type > b.type ? -1 : 1;
//                }
//                //按品质比
//                else if (a.quality != b.quality)
//                {
//                    return a.quality > b.quality ? -1 : 1;
//                }
//                //否则就直接按名字长度比
//                else
//                {
//                    return a.name.Length > b.name.Length ? -1 : 1;
//                }
//            }
//            );

//            Console.WriteLine("*********************");
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine(itemList[i]);
//            }

//            Dictionary<int, string> dic = new Dictionary<int, string>();
//            dic.Add(2, "123123");
//            dic.Add(6, "123123");
//            dic.Add(1, "123123");
//            dic.Add(4, "123123");
//            dic.Add(3, "123123");
//            dic.Add(5, "123123");

//            List<KeyValuePair<int, string>> list__ = new List<KeyValuePair<int, string>>(); 
//            foreach(KeyValuePair<int,string> item in dic)
//            {
//                list__.Add(item);
//                Console.WriteLine(item.Key + "_" + item.Value);
//            }
//            list__.Sort((a, b) =>
//            {
//                return a.Key > b.Key ? 1 : -1;
//            });

//            foreach(KeyValuePair<int, string> item in list__)
//            {
//                Console.WriteLine(item.Key + "_" + item.Value);
//            }





//        }

//        static int SortFun(Monster m1, Monster m2)
//        {
//            switch (Monster.SortType)
//            {
//                case 1:
//                    return m1.atk > m2.atk ? 1 : -1;
//                case 2:
//                    return m1.def > m2.def ? 1 : -1;
//                case 3:
//                    return m1.hp > m2.hp ? 1 : -1;
//            }
//            return 0;
//        }
//    }
//}

namespace Lession_
{
    enum E_MoveDir
    {
        Up,Down,Right,Left,
    }

    class Icon
    {
        public E_MoveDir dir;
        public int x;
        public int y;
        public Icon(int x,int y, E_MoveDir dir)
        {
            this.x = x;
            this.y = y;
            this.dir = dir;
        }
        public void Move()
        {
            switch (dir)
            {
                case E_MoveDir.Up:
                    y--;
                    break;
                case E_MoveDir.Down:
                    y++;
                    break;
                case E_MoveDir.Right:
                    x+=2;
                    break;
                case E_MoveDir.Left:
                    x-=2;
                    break;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("●");
        }
        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("  ");
        }
        public void ChangeDir(E_MoveDir dir) { this.dir = dir; }
    }
    class Program
    {
        static Icon icon;
        static void Main(string[] args)
        {
            Console.WriteLine("多线程练习题");
            //多线程练习题
            Console.CursorVisible=false;
            icon = new Icon(10,5,E_MoveDir.Up);
            icon.Draw();
            Thread t = new Thread(NewThreadLogic);
            t.IsBackground=true;
            t.Start();
            while (true)
            {
                Thread.Sleep(100);
                icon.Clear();
                icon.Move();
                icon.Draw();

            }
        }

        static void NewThreadLogic()
        {
            while(true)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        icon.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        icon.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.A:
                        icon.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        icon.ChangeDir(E_MoveDir.Right);
                        break;
                }
            }
        }
    }


}