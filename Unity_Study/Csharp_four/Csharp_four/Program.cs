using System;
using System.Collections;

//namespace Lesson1_ArrayList
//{
//    class Test
//    {

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ArrayList");

//            #region 练习题回顾
//            //C#核心中  索引器的练习题
//            //自定义一个整形数组类，该类中有一个整形数组变量
//            //为它封装增删查改的方法
//            #endregion

//            #region 知识点一 ArrayList的本质
//            //ArrayList是一个C#为我们封装好的类，
//            //它的本质是一个object类型的数组，
//            //ArrayList类帮助我们实现了很多方法，
//            //比如数组的增删查改
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间using System.Collections;
//            ArrayList array = new ArrayList();
//            #endregion

//            #region 知识点三 增删查改

//            #region 增
//            array.Add(1);
//            array.Add("123");
//            array.Add(true);
//            array.Add(new object());
//            array.Add(new Test());
//            array.Add(1);
//            array.Add(true);

//            ArrayList array2 = new ArrayList();
//            array2.Add(123);
//            //范围增加（批量增加 把另一个list容器里面的内容加到后面）
//            //array.AddRange(array2);
//            array.AddRange(array2);

//            array.Insert(1, "12345676");
//            Console.WriteLine(array[1]);
//            #endregion

//            #region 删

//            //移除指定元素 从头找 找到删
//            array.Remove(1);
//            //移除指定位置的元素
//            array.RemoveAt(2);
//            //清空
//            //array.Clear();

//            #endregion

//            #region 查
//            //得到指定位置的元素
//            Console.WriteLine(array[0]);

//            //查看元素是否存在
//            //array.Contains("1234");
//            if (array.Contains("1234"))
//            {
//                Console.WriteLine("存在123");
//            }

//            //正向查找元素位置
//            //找到的返回值 是位置 找不到 返回值 是-1
//            int index = array.IndexOf(true);
//            Console.WriteLine(index);

//            Console.WriteLine(array.IndexOf(false));

//            //反向查找元素位置
//            //返回时从头开始的索引数
//            index = array.LastIndexOf(true);
//            Console.WriteLine(index);
//            #endregion

//            #region 改
//            Console.WriteLine(array[0]);
//            array[0] = "999";
//            Console.WriteLine(array[0]);
//            #endregion

//            #endregion

//            #region 遍历
//            //长度
//            Console.WriteLine(array.Count);
//            //容量
//            //避免产生过多的垃圾
//            Console.WriteLine(array.Capacity);
//            Console.WriteLine("***********************");
//            for (int i = 0; i < array.Count; i++)
//            {
//                Console.WriteLine(array[i]);
//            }
//            Console.WriteLine("***********************");
//            //迭代器遍历
//            foreach(object item in array)
//            {
//                Console.WriteLine(item);
//            }
//            foreach (object item in array)
//            {
//                Console.WriteLine(item);
//            }

//            #endregion

//            #region 知识点四 装箱拆箱
//            //ArrayList本质上是一个可以自动扩容的object数组，
//            //由于用万物之父来存储数据，自然存在装箱拆箱。
//            //当往其中进行值类型存储时就是在装箱，当将值类型对象取出来转换使用时，就存在拆箱。
//            //所以ArrayList尽量少用，之后我们会学习更好的数据容器。

//            int k = 1;
//            array[0] = k;//装箱
//            k = (int)array[0];//拆箱
//            #endregion
//        }
//    }
//}

//namespace Lession_stack
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Stack练习题");
//            #region 练习一
//            //请简述栈的存储规则
//            //先进后出
//            #endregion

//            #region 练习二
//            //写一个方法计算任意一个数的二进制数
//            //使用栈结构方式存储，之后打印出来
//            Calc(10);
//            Calc(2);
//            Calc(3);
//            Calc(8);
//            Calc(16);
//            #endregion
//        }

//        static void Calc(uint num)
//        {
//            Console.Write("{0}的二进制是：", num);
//            Stack stack_ = new Stack();
//            while (true)
//            {
//                stack_.Push(num % 2);
//                num /= 2;
//                if(num == 1)
//                {
//                    stack_.Push(num);
//                    break;
//                }
//            }
//            while (stack_.Count > 0)
//            {
//                Console.Write(stack_.Pop());
//            }
//            Stack stack = new Stack();
//            //while (true)
//            //{
//            //    stack.Push(num % 2);
//            //    num /= 2;
//            //    if (num == 1)
//            //    {
//            //        stack.Push(num);
//            //        break;
//            //    }
//            //}
//            ////循环弹栈
//            //while (stack.Count > 0)
//            //{
//            //    Console.Write(stack.Pop());
//            //}
//            Console.WriteLine();

//            ////10
//            //num = 10;
//            //stack.Push(num % 2);//0
//            //num /= 2;//5
//            //stack.Push(num % 2);//1
//            //num /= 2;//2
//            //stack.Push(num % 2);//0
//            //num /= 2;//1
//            //if( num == 1 )
//            //{
//            //    stack.Push(num);//1
//            //}
//        }
//    }
//}


//namespace Lesson3_Queue
//{
//    class Test
//    {

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Queue");

//            #region 知识点一 Queue本质
//            //Queue是一个C#为我们封装好的类
//            //它的本质也是object[]数组，只是封装了特殊的存储规则

//            //Queue是队列存储容器
//            //队列是一种先进先出的数据结构
//            //先存入的数据先获取，后存入的数据后获取
//            //先进先出
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间 System.Collections
//            Queue queue = new Queue();
//            #endregion

//            #region 知识点三 增取查改

//            #region 增
//            queue.Enqueue(1);
//            queue.Enqueue("123");
//            queue.Enqueue(1.4f);
//            queue.Enqueue(new Test());
//            #endregion

//            #region 取
//            //队列中不存在删除的概念
//            //只有取的概念 取出先加入的对象
//            object v = queue.Dequeue();
//            Console.WriteLine(v);
//            v = queue.Dequeue();
//            Console.WriteLine(v);
//            #endregion

//            #region 查
//            //1.查看队列头部元素但不会移除
//            v = queue.Peek();
//            Console.WriteLine(v);
//            v = queue.Peek();
//            Console.WriteLine(v);

//            //2.查看元素是否存在于队列中
//            if (queue.Contains(1.4f))
//            {
//                Console.WriteLine("队列中存在1.4f");
//            }

//            #endregion

//            #region 改
//            //队列无法改变其中的元素 只能进出队列
//            //实在要改 只有清
//            Console.WriteLine(queue.Count);
//            queue.Clear();
//            queue.Enqueue(1);
//            queue.Enqueue(2);
//            queue.Enqueue(3);
//            #endregion

//            #endregion

//            #region 知识点四 遍历
//            //1.长度
//            Console.WriteLine(queue.Count);
//            //2.用foreach遍历
//            foreach (object item in queue)
//            {
//                Console.WriteLine(item);
//            }
//            //3.还有一种遍历方式
//            //  将队列转换为object数组
//            object[] array = queue.ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine(array[i]);
//            }

//            //4.循环出列
//            while (queue.Count > 0)
//            {
//                object o = queue.Dequeue();
//                Console.WriteLine(o);
//            }
//            Console.WriteLine(queue.Count);
//            #endregion

//            #region 知识点五 装箱拆箱
//            //由于用万物之父来存储数据，自然存在装箱拆箱。
//            //当往其中进行值类型存储时就是在装箱
//            //当将值类型对象取出来转换使用时，就存在拆箱。
//            #endregion
//        }
//    }
//}

//namespace Lesson4_Hashtable
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hashtable");

//            #region 知识点一 Hashtalbe的本质
//            //Hashtable（又称散列表） 是基于键的哈希代码组织起来的 键/值对
//            //它的主要作用是提高数据查询的效率
//            //使用键来访问集合中的元素
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间 System.Collections
//            Hashtable hashtable = new Hashtable();
//            #endregion

//            #region 知识点三 增删查改

//            #region 增
//            hashtable.Add(1, "123");
//            hashtable.Add("123", 2);
//            hashtable.Add(true, false);
//            hashtable.Add(false, false);
//            //注意：不能出现相同键
//            #endregion

//            #region 删
//            //1.只能通过键去删除
//            hashtable.Remove(1);
//            //2.删除不存在的键 没反应
//            hashtable.Remove(2);
//            hashtable.Remove(true);

//            //3.或者直接清空
//            hashtable.Clear();
//            hashtable.Add(1, "123");
//            hashtable.Add(2, "1234");
//            hashtable.Add(3, "123");
//            hashtable.Add("123123", 12);
//            #endregion

//            #region 查
//            //1.通过键查看值
//            //  找不到会返回空
//            Console.WriteLine(hashtable[1]);
//            Console.WriteLine(hashtable[4]);//null
//            Console.WriteLine(hashtable["123123"]);

//            //2.查看是否存在
//            //根据键检测
//            if (hashtable.Contains(2))
//            {
//                Console.WriteLine("存在键为2的键值对");
//            }
//            if (hashtable.ContainsKey(2))
//            {
//                Console.WriteLine("存在键为2的键值对");
//            }

//            //根据值检测
//            if (hashtable.ContainsValue(12))
//            {
//                Console.WriteLine("存在值为12的键值对");
//            }
//            if(hashtable.ContainsValue(true))
//            {
//                Console.WriteLine("存在值为true的键值对");
//            }
//            #endregion

//            #region 改
//            //只能改 键对应的值内容 无法修改键
//            Console.WriteLine(hashtable[1]);
//            hashtable[1] = 100.5f;
//            Console.WriteLine(hashtable[1]);
//            #endregion

//            #endregion

//            #region 知识点四 遍历
//            //得到键值对 对数
//            Console.WriteLine(hashtable.Count);

//            //1.遍历所有键
//            foreach (object item in hashtable.Keys)
//            {
//                Console.WriteLine("键：" + item);
//                Console.WriteLine("值：" + hashtable[item]);
//            }

//            //2.遍历所有值
//            foreach (object item in hashtable.Values)
//            {
//                Console.WriteLine("值：" + item);
//            }

//            //3.键值对一起遍历
//            foreach (DictionaryEntry item in hashtable)
//            {
//                Console.WriteLine("键：" + item.Key + "值：" + item.Value);
//            }
//            foreach(DictionaryEntry item in hashtable)
//            {
//                Console.WriteLine("键：" + item.Key + "值：" + item.Value);
//            }
//            //4.迭代器遍历法
//            IDictionaryEnumerator myEnumerator = hashtable.GetEnumerator();
//            bool flag = myEnumerator.MoveNext();
//            while (flag)
//            {
//                Console.WriteLine("键：" + myEnumerator.Key + "值：" + myEnumerator.Value);
//                flag = myEnumerator.MoveNext();
//            }

//            IDictionaryEnumerator myEnum =hashtable.GetEnumerator();
//            bool flag1 = myEnum.MoveNext();
//            Console.WriteLine("键"+myEnum.Key+" 值 "+myEnum.Value);
//            flag1 = myEnum.MoveNext();
//            Console.WriteLine("键" + myEnum.Key + " 值 " + myEnum.Value);
//            Console.WriteLine("键" + myEnum.Key + " 值 " + myEnum.Value);
//            #endregion

//            #region 知识点五 装箱拆箱
//            //由于用万物之父来存储数据，自然存在装箱拆箱
//            //当往其中进行值类型存储时就是在装箱
//            //当将值类型对象取出来转换使用时，就存在拆箱
//            #endregion
//        }
//    }
//}

//namespace Lesson6_泛型约束
//{
//    #region 知识回顾
//    //泛型类
//    class TestClass<T, U>
//    {
//        public T t;
//        public U u;

//        public U TestFun(T t)
//        {
//            return default(U);
//        }

//        //泛型函数
//        public V TestFun<K, V>(K k)
//        {
//            return default(V);
//        }
//    }
//    #endregion

//    #region 知识点一 什么是泛型约束
//    //让泛型的类型有一定的限制
//    //关键字：where
//    //泛型约束一共有6种
//    //1.值类型                              where 泛型字母:struct
//    //2.引用类型                            where 泛型字母:class
//    //3.存在无参公共构造函数                 where 泛型字母:new()
//    //4.某个类本身或者其派生类               where 泛型字母:类名
//    //5.某个接口的派生类型                  where 泛型字母:接口名
//    //6.另一个泛型类型本身或者派生类型       where 泛型字母:另一个泛型字母

//    // where 泛型字母:(约束的类型)
//    #endregion

//    #region 知识点二 各泛型约束讲解

//    #region 值类型约束
//    class Test1<T> where T : struct
//    {
//        public T value;
//        public void TestFun<K>(K v) where K : struct
//        {
//        }
//    }
//    #endregion

//    #region 引用类型约束
//    class Test2<T> where T : class
//    {
//        public T value;

//        public void TestFun<K>(K k) where K : class
//        {

//        }
//    }
//    #endregion

//    #region T 必须具有公共无参构造约束
//    //class Test3<T> where T: new()
//    //{
//    //    public T value;
//    //    public void TestFun<K>(K k) where K :new()
//    //    {
//    //    }
//    //}
//    class Test3<T> where T : new()
//    {
//        public T value;

//        public void TestFun<K>(K k) where K : new()
//        {

//        }
//    }

//    class Test1
//    {
//        public Test1()
//        {

//        }
//    }

//    class Test2
//    {
//        public Test2(int a)
//        {

//        }
//    }
//    #endregion

//    #region 类约束，T必须是Test1或者其派生类
//    class Test4<T> where T : Test1
//    {
//        public T value;

//        public void TestFun<K>(K k) where K : Test1
//        {

//        }
//    }

//    class Test3 : Test1
//    {

//    }
//    #endregion

//    #region 接口约束
//    interface IFly
//    {

//    }

//    interface IMove : IFly
//    {

//    }

//    class Test4 : IFly
//    {

//    }

//    class Test5<T> where T : IFly
//    {
//        public T value;

//        public void TestFun<K>(K k) where K : IFly
//        {

//        }
//    }
//    #endregion

//    #region 另一个泛型约束
//    class Test6<T, U> where T : U
//    {
//        public T value;

//        public void TestFun<K, V>(K k) where K : V
//        {

//        }
//    }
//    #endregion

//    #endregion

//    #region 知识点三 约束的组合使用
//    class Test7<T> where T : class, new()
//    {

//    }
//    #endregion

//    #region 知识点四 多个泛型有约束
//    class Test8<T, K> where T : class, new() where K : struct
//    {

//    }
//    #endregion

//    #region 总结
//    //泛型约束：让类型有一定限制
//    //class
//    //struct
//    //new()
//    //类名
//    //接口名
//    //另一个泛型字母

//    //注意：
//    //1.可以组合使用
//    //2.多个泛型约束 用where连接即可
//    #endregion

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("泛型约束");

//            TestClass<string, int> t = new TestClass<string, int>();
//            t.t = "1`23123";
//            t.u = 10;

//            t.TestFun("123");

//            t.TestFun<float, double>(1.4f);

//            Test1<int> t1 = new Test1<int>();
//            t1.TestFun<float>(1.3f);

//            Test2<Random> t2 = new Test2<Random>();
//            t2.value = new Random();
//            t2.TestFun<object>(new object());

//            Test3<Test1> t3 = new Test3<Test1>();

//            Test4<Test3> t4 = new Test4<Test3>();

//            Test5<IMove> t5 = new Test5<IMove>();
//            Test5<Test4> t55 = new Test5<Test4>();
//            //t5.value = new Test4();

//            Test6<Test4, IFly> t6 = new Test6<Test4, IFly>();
//            //Test6<IFly, Test4> tt6 = new Test6<IFly, Test4>(); //错误
//        }
//    }
//}

//namespace Lesson7_List
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("List");

//            #region 知识点一 List的本质
//            //List是一个C#为我们封装好的类，
//            //它的本质是一个可变类型的泛型数组，
//            //List类帮助我们实现了很多方法，
//            //比如泛型数组的增删查改
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间
//            //using System.Collections.Generic
//            List<int> list = new List<int>();
//            List<string> list2 = new List<string>();
//            List<bool> list3 = new List<bool>();
//            #endregion

//            #region 知识点三 增删查改

//            #region 增
//            list.Add(1);
//            list.Add(2);
//            list.Add(3);
//            list.Add(4);

//            list2.Add("123");

//            List<string> listStr = new List<string>();
//            listStr.Add("123");
//            list2.AddRange(listStr);

//            list.Insert(0, 999);
//            Console.WriteLine(list[0]);
//            #endregion

//            #region 删
//            //1.移除指定元素
//            list.Remove(1);
//            //2.移除指定位置的元素
//            list.RemoveAt(0);
//            //3.清空
//            list.Clear();

//            list.Add(1);
//            list.Add(2);
//            list.Add(3);
//            list.Add(4);
//            list.Add(1);
//            #endregion

//            #region 查
//            //1.得到指定位置的元素
//            Console.WriteLine(list[0]);
//            //2.查看元素是否存在
//            if (list.Contains(1))
//            {
//                Console.WriteLine("存在元素 1");
//            }
//            //3.正向查找元素位置
//            // 找到返回位置 找不到 返回-1
//            int index = list.IndexOf(5);
//            Console.WriteLine(index);
//            //4.反向查找元素位置
//            // 找到返回位置 找不到 返回-1
//            index = list.LastIndexOf(2);
//            Console.WriteLine(index);
//            #endregion

//            #region 改
//            Console.WriteLine(list[0]);
//            list[0] = 99;
//            Console.WriteLine(list[0]);
//            #endregion

//            #endregion

//            #region 知识点四 遍历
//            //长度
//            Console.WriteLine(list.Count);
//            //容量
//            //避免产生垃圾
//            Console.WriteLine(list.Capacity);
//            Console.WriteLine("**********************");
//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine(list[i]);
//            }
//            Console.WriteLine("**********************");
//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }

//            #endregion
//        }
//    }
//}

//namespace Lesson8_Dictionary
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Dictionary");

//            #region 知识点一 Dictionary的本质
//            //可以将Dictionary理解为 拥有泛型的Hashtable
//            //它也是基于键的哈希代码组织起来的 键/值对
//            //键值对类型从Hashtable的object变为了可以自己制定的泛型
//            #endregion

//            #region 知识点二 申明
//            //需要引用命名空间 using System.Collections.Generic
//            Dictionary<int, string> dictionary = new Dictionary<int, string>();
//            #endregion

//            #region 知识点三 增删查改

//            #region 增
//            //注意：不能出现相同键
//            dictionary.Add(1, "123");
//            dictionary.Add(2, "222");
//            dictionary.Add(3, "222");
//            //dictionary.Add(3, "123");
//            #endregion

//            #region 删
//            //1.只能通过键去删除
//            //  删除不存在键 没反应
//            dictionary.Remove(1);
//            dictionary.Remove(4);

//            //2.清空
//            dictionary.Clear();
//            dictionary.Add(1, "123");
//            dictionary.Add(2, "222");
//            dictionary.Add(3, "222");
//            #endregion

//            #region 查
//            //1.通过键查看值
//            //  找不到直接报错
//            Console.WriteLine(dictionary[2]);
//            //Console.WriteLine(dictionary[4]);
//            Console.WriteLine(dictionary[1]);

//            //2.查看是否存在
//            //  根据键检测
//            if (dictionary.ContainsKey(4))
//            {
//                Console.WriteLine("存在键为1的键值对");
//            }
//            //  根据值检测
//            if (dictionary.ContainsValue("1234"))
//            {
//                Console.WriteLine("存在值为123的键值对");
//            }

//            #endregion

//            #region 改
//            Console.WriteLine(dictionary[1]);
//            dictionary[1] = "555";
//            Console.WriteLine(dictionary[1]);
//            #endregion

//            #endregion

//            #region 知识点四 遍历
//            Console.WriteLine("**************");
//            Console.WriteLine(dictionary.Count);
//            //1.遍历所有键
//            foreach (int item in dictionary.Keys)
//            {
//                Console.WriteLine(item);
//                Console.WriteLine(dictionary[item]);
//            }
//            //2.遍历所有值
//            Console.WriteLine("**************");
//            foreach (string item in dictionary.Values)
//            {
//                Console.WriteLine(item);
//            }
//            //3.键值对一起遍历
//            Console.WriteLine("**************");
//            foreach (KeyValuePair<int, string> item in dictionary)
//            {
//                Console.WriteLine("键：" + item.Key + "值：" + item.Value);
//            }
//            #endregion
//        }
//    }
//}

//namespace Lesson11_泛型栈和队列
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("泛型栈和队列");

//            #region 知识点一 回顾数据容器

//            #region 变量
//            //无符号
//            //byte ushort uint ulong
//            //有符号
//            //sbyte short int long
//            //浮点数
//            //float double decimal
//            //特殊
//            //char bool string
//            #endregion

//            #region 复杂数据容器
//            //枚举 enum
//            //结构体 struct
//            //数组（一维、二维、交错） []  [,]  [][]
//            //类
//            #endregion

//            #region 数据集合
//            //using System.Collections;

//            //ArrayList  object数据列表
//            //Stack 栈  先进后出
//            //Queue 队列  先进先出
//            //Hashtable   哈希表  键值对
//            #endregion

//            #region 泛型数据集合
//            //using System.Collections.Generic;

//            //List  列表  泛型列表
//            //Dictionary 字典  泛型哈希表
//            //LinkedList 双向链表 
//            //Statck 泛型栈
//            //Queue 泛型队列
//            #endregion

//            #endregion

//            #region 知识点二 泛型栈和队列
//            //命名空间：using System.Collections.Generic;
//            //使用上 和之前的Stack和Queue一模一样
//            Stack<int> stack = new Stack<int>();
//            Queue<object> queue = new Queue<object>();
//            #endregion
//        }
//    }
//}

using System;
using System.Runtime.CompilerServices;
using List_paixu;

//namespace Lesson12_委托
//{
//    #region 知识点一 委托是什么
//    //委托是 函数(方法)的容器 
//    //可以理解为表示函数(方法)的变量类型
//    //用来 存储、传递函数(方法)
//    //委托的本质是一个类，用来定义函数(方法)的类型（返回值和参数的类型）
//    //不同的 函数(方法)必须对应和各自"格式"一致的委托
//    #endregion

//    #region 知识点二 基本语法
//    //关键字 ： delegate
//    //语法：访问修饰符 delegate 返回值 委托名(参数列表);

//    //写在哪里？
//    //可以申明在namespace和class语句块中
//    //更多的写在namespace中

//    //简单记忆委托语法 就是 函数申明语法前面加一个delegate关键字
//    #endregion

//    #region 知识点三 定义自定义委托
//    //访问修饰默认不写 为public 在别的命名空间中也能使用
//    //private 其它命名空间就不能用了
//    //一般使用public

//    //申明了一个可以用来存储无参无返回值函数的容器
//    delegate void Myfunc1();
//    //这里只是定义了规则 并没有使用
//    delegate void MyFun();
//    public delegate void MyFun_2(int a);
//    //委托规则的申明 是不能重名（同一语句块中）
//    //表示用来装载或传递 返回值为int 有一个int参数的函数的 委托 容器规则
//    public delegate int MyFun2(int a);

//    //委托是支持 泛型的 可以让返回值和参数 可变 更方便我们的使用
//    delegate T MyFun3<T, K>(T v, K k);
//    delegate T Myfunc33<T, K>(T v, K k);
//    #endregion

//    #region 知识点四 使用定义好的委托
//    //委托变量是函数的容器

//    //委托常用在：
//    //1.作为类的成员
//    //2.作为函数的参数
//    class Test
//    {
//        public MyFun fun;
//        public MyFun2 fun2;

//        public Action action;

//        public void TestFun(MyFun fun, MyFun2 fun2)
//        {
//            //先处理一些别的逻辑 当这些逻辑处理完了 再执行传入的函数
//            int i = 1;
//            i *= 2;
//            i += 2;

//            //fun();
//            //fun2(i);
//            //this.fun = fun;
//            //this.fun2 = fun2;
//        }


//        #region 增
//        public void AddFun(MyFun fun, MyFun2 fun2)
//        {
//            this.fun += fun;
//            this.fun2 += fun2;
//        }
//        #endregion

//        #region 删
//        public void RemoveFun(MyFun fun, MyFun2 fun2)
//        {
//            //this.fun = this.fun - fun;
//            this.fun -= fun;
//            this.fun2 -= fun2;
//        }
//        #endregion
//    }
//    #endregion

//    #region 知识点五 委托变量可以存储多个函数(多播委托)


//    #endregion



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("委托");
//            //专门用来装载 函数的 容器
//            MyFun f = new MyFun(Fun);
//            MyFun f1 = new MyFun(Fun3);
//            Console.WriteLine("1");
//            Console.WriteLine("2");
//            Console.WriteLine("3");
//            Console.WriteLine("4");
//            Console.WriteLine("5");
//            f.Invoke();
//            f1.Invoke();

//            MyFun f2 = Fun;
//            MyFun f2_ = Fun;
//            Console.WriteLine("1");
//            Console.WriteLine("2");
//            Console.WriteLine("3");
//            Console.WriteLine("4");
//            Console.WriteLine("5");
//            f2();
//            f2_();

//            MyFun2 f3 = Fun2;
//            Console.WriteLine(f3(1));

//            MyFun2 f4 = new MyFun2(Fun2);
//            Console.WriteLine(f4.Invoke(3));

//            Test t = new Test();

//            t.TestFun(Fun, Fun2);
//            Console.WriteLine("***************");
//            //如何用委托存储多个函数
//            //MyFun ff = null;
//            //ff += Fun;
//            //ff += Fun3;


//            MyFun ff = null;
//            //ff = ff + Fun;
//            ff += Fun;
//            ff += Fun3;
//            ff += Fun7;
//            ff += Fun;
//            ff += Fun3;
//            ff();
//            //从容器中移除指定的函数
//            ff -= Fun;
//            //多减 不会报错 无非就是不处理而已
//            ff -= Fun3;
//            //ff -= Fun;
//            ff();
//            Console.WriteLine("***************");
//            //清空容器
//            ff = null;
//            if (ff != null)
//            {
//                ff();
//            }

//            #region 知识点六 系统定义好的委托
//            //使用系统自带委托 需要引用using System;
//            //无参无返回值
//            Action action = Fun;
//            action += Fun3;
//            action();

//            //可以指定返回值类型的 泛型委托
//            Func<string> funcString = Fun4;
//            Func<int> funcInt = Fun5;
//            Func<float> funcffloat = func_1;

//            //可以传n个参数的  系统提供了 1到16个参数的委托 直接用就行了
//            Action<int, string> action2 = Fun6;
//            Action<int, float, string, double> action3 = null;

//            //可以穿n个参数的 并且有返回值的 系统也提供了 16个委托
//            Func<int, int> func2 = Fun2;
//            Func<int, float, int> funccc = null;
//            #endregion
//        }

//        static void Fun()
//        {
//            Console.WriteLine("张三做什么");
//        }
//        static void Fun3()
//        {
//            Console.WriteLine("李四做什么");
//        }

//        static void Fun7()
//        {
//            Console.WriteLine(0);
//            Console.WriteLine("string");
//        }
//        static string Fun4()
//        {
//            return "";
//        }

//        static int Fun5()
//        {
//            return 1;
//        }

//        static float func_1()
//        {
//            return 0.5f;
//        }
//        static void Fun6(int i, string s)
//        {
//            Console.WriteLine(i);
//            Console.WriteLine(s);
//        }

//        static int Fun2(int value)
//        {
//            return value;
//        }
//    }

//    //总结
//    //简单理解 委托 就是装载、传递函数的容器而已
//    //可以用委托变量 来存储函数或者传递函数的
//    //系统其实已经提供了很多委托给我们用 
//    //Action:没有返回值，参数提供了 0~16个委托给我们用
//    //Func:有返回值，参数提供了 0~16个委托给我们用
//}


//namespace Lesson_事件
//{
//    #region 知识点一 事件是什么
//    //事件是基于委托的存在
//    //事件是委托的安全包裹
//    //让委托的使用更具有安全性
//    //事件 是一种特殊的变量类型
//    #endregion

//    #region 知识点二 事件的使用
//    //申明语法：
//    //访问修饰符 event 委托类型 事件名;
//    //事件的使用：
//    //1.事件是作为 成员变量存在于类中
//    //2.委托怎么用 事件就怎么用
//    //事件相对于委托的区别:
//    //1.不能在类外部 赋值
//    //2.不能再类外部 调用
//    //注意：
//    //它只能作为成员存在于类和接口以及结构体中
//    class Test
//    {
//        //委托成员变量 用于存储 函数的
//        public Action myFun;
//        //事件成员变量 用于存储 函数的
//        public event Action myEvent;

//        public Test()
//        {
//            //事件的使用和委托 一模一样 只是有些 细微的区别
//            myFun = TestFun;
//            myFun += TestFun;
//            myFun -= TestFun;
//            myFun();
//            myFun.Invoke();
//            myFun = null;

//            myEvent = TestFun;
//            myEvent += TestFun;
//            myEvent -= TestFun;
//            myEvent();
//            myEvent.Invoke();
//            myEvent = null;
//        }

//        public void DoEvent()
//        {
//            if(myEvent!=null)
//            {
//                this.myEvent();
//            }
//        }

//        public void TestFun()
//        {
//            Console.WriteLine("123");
//        }
//    }
//    #endregion

//    #region 知识点三 为什么有事件
//    //1.防止外部随意置空委托
//    //2.防止外部随意调用委托
//    //3.事件相当于对委托进行了一次封装 让其更加安全
//    #endregion
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("事件");
//            Test t = new Test();
//            //委托可以在外部赋值
//            t.myFun = null;
//            t.myFun = t.myFun + TestFun;
//            t.myFun += TestFun;

//            //事件是不能再外部赋值的
//            //t.myEvent = null;
//            //t.myEvent = TestFun;
//            //虽然不能直接赋值 但是可以 加减 去添加移除记录的函数
//            t.myEvent += TestFun;
//            t.myEvent -= TestFun;

//            //委托是可以在外部调用的
//            t.myFun();
//            t.myFun.Invoke();

//            //事件不能再外部调用
//            //t.myEvent();
//            //只能在类的内部去封装 调用
//            t.DoEvent();

//            Action a = TestFun;
//            //事件 是不能作为临时变量在函数中使用的
//            //EventArgs Action ae = TestFun;
//        }

//        static void TestFun()
//        {

//        }
//    }


//}
//namespace Lesson14_匿名函数
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("匿名函数");
//            #region 知识点一 什么是匿名函数
//            //顾名思义，就是没有名字的函数
//            //匿名函数的使用主要是配合委托和事件进行使用
//            //脱离委托和事件 是不会使用匿名函数的
//            #endregion
//            #region 知识点二 基本语法
//            //delegate (参数列表)
//            //{
//            //    //函数逻辑
//            //};
//            //何时使用？
//            //1.函数中传递委托参数时
//            //2.委托或事件赋值时
//            #endregion
//            #region shiyong
//            //1.无参无返回
//            //这样申明匿名函数 只是在申明函数而已 还没有调用
//            //真正调用它的时候 是这个委托容器啥时候调用 就什么时候调用这个匿名函数
//            Action a = delegate ()
//            {
//                Console.WriteLine("匿名函数逻辑");
//            };
//            a();
//            a.Invoke();
//            //2.有参
//            Action<int, string> b = delegate (int a, string b)
//            {
//                Console.WriteLine(a);
//                Console.WriteLine(b);
//            };
//            b(100, "123");

//            Func<string> c = delegate ()
//            { return "123456"; };
//            Console.WriteLine(c());

//            //4.一般情况会作为函数参数传递 或者 作为函数返回值
//            Test t = new Test();
//            Action ac = delegate ()
//            { Console.WriteLine("随参数传入的匿名函数逻辑"); };
//            t.Dosomthing(540, ac);
//            t.Dosomthing(100, delegate ()
//            { Console.WriteLine("随参数传入的匿名函数逻辑"); }
//            ); 

//            //返回值
//            Action ac2 = t.GetFun();
//            ac2();
//            ac2.Invoke();
//            t.GetFun()();
//            #endregion
//            #region 知识点四 匿名函数的缺点
//            //添加到委托或事件容器中后 不记录 无法单独移除

//            Action ac3 = delegate ()
//            {
//                Console.WriteLine("匿名函数一");
//            };

//            ac3 += delegate ()
//            {
//                Console.WriteLine("匿名函数二");
//            };

//            ac3();
//            //因为匿名函数没有名字 所以没有办法指定移除某一个匿名函数
//            //此匿名函数 非彼匿名函数 不能通过看逻辑是否一样 就证明是一个 
//            //ac3 -= delegate ()
//            //{
//            //    Console.WriteLine("匿名函数一");
//            //};
//            ac3 = null;
//            //ac3();
//            #endregion
//        }
//    }

//    class Test
//    {
//        public Action action;

//        //作为参数传递时
//        public void Dosomthing(int a, Action fun)
//        {
//            Console.WriteLine(a);
//            fun();
//        }

//        //作为返回值
//        public Action GetFun()
//        {
//            return delegate () {
//                Console.WriteLine("函数内部返回的一个匿名函数逻辑");
//            };

//        }

//        public void TestTTTT()
//        {

//        }
//    }
//}

//namespace Lambda表达式
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            #region lambda使用
//            Action a = () => { Console.WriteLine("无参无返回值的lambad表达式"); };
//            a();
//            Action<int> a2 = (int value) => { Console.WriteLine("有参数Lambad表达式{0}", value);  };
//            a2.Invoke(100);
//            //3.甚至参数类型都可以省略 参数类型和委托或事件容器一致
//            Action<int> a3 = (value) =>
//            {
//                Console.WriteLine("省略参数类型的写法{0}", value);
//            };
//            a3(200);
//            Func<string, int> a4 = (string value) =>
//            {
//                Console.WriteLine("有返回值有参数的那么大表达式{0}", value);
//                return 1;
//            };
//            Console.WriteLine(a4("123123"));
//            #endregion
//            Test t = new Test();
//            t.DoSomething();
//        }
//    }
//    #region 知识点四 闭包
//    //内层的函数可以引用包含在它外层的函数的变量
//    //即使外层函数的执行已经终止
//    //注意：
//    //该变量提供的值并非变量创建时的值，而是在父函数范围内的最终值。
//    #endregion

//    class Test
//    {
//        public event Action action;
//        public Test()
//        {
//            int value = 10;
//            //这里就形成了闭包
//            //因为 当构造函数执行完毕时  其中申明的临时变量value的声明周期被改变了
//            action = () => { Console.WriteLine(value); };
//            for(int i=0;i<10;++i)
//            {
//                //此index 非彼index
//                int index = i;
//                action += () =>
//                {
//                    Console.WriteLine(index);
//                };
//            }
//        }
//        public void DoSomething()
//        {
//            action();
//        }
//    }
//}

namespace List_paixu
{
    class Item : IComparable<Item>
    {
        public int money;
        public Item(int money)
        {
            this.money = money;
        }
        public int CompareTo(Item other)
        {
            if (this.money > other.money)
            {
                return -1;
            }
            else
            {
                return 1;
            }
            return 0;
        }
    }

    class ShopItem
    {
        public int id;

        public ShopItem(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List排序");
            #region 知识点一 List自带排序方法
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(6);
            list.Add(1);
            list.Add(4);
            list.Add(5);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //list提供了排序方法
            list.Sort();
            Console.WriteLine("**************");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //ArrayList中也有Sort排序方法
            #endregion

            List<Item> itemList = new List<Item>();
            itemList.Add(new Item(10));
            itemList.Add(new Item(99));
            itemList.Add(new Item(24));
            itemList.Add(new Item(100));
            itemList.Add(new Item(12));
            itemList.Sort();
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(itemList[i].money);
            }

            List<ShopItem> shopItems = new List<ShopItem>();
            shopItems.Add(new ShopItem(2));
            shopItems.Add(new ShopItem(1));
            shopItems.Add(new ShopItem(4));
            shopItems.Add(new ShopItem(3));
            shopItems.Add(new ShopItem(6));
            shopItems.Add(new ShopItem(5));
            //shopItems.Sort(SortShopItem);
            shopItems.Sort(delegate (ShopItem a, ShopItem b)
            {
                if (a.id > b.id) return -1;
                return 1;
            });
            //shopItems.Sort((a, b) => { return a.id > b.id ? 1 : -1; });
            Console.WriteLine("*********************");
            for (int i = 0; i < shopItems.Count; i++)
            {
                Console.WriteLine(shopItems[i].id);
            }

        }
        static int SortShopItem(ShopItem a, ShopItem b)
        {
            if (a.id > b.id) return -1;
            return 1;
        }
    }
}