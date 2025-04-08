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

using System;
using System.Collections.Generic;

namespace Lesson8_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");

            #region 知识点一 Dictionary的本质
            //可以将Dictionary理解为 拥有泛型的Hashtable
            //它也是基于键的哈希代码组织起来的 键/值对
            //键值对类型从Hashtable的object变为了可以自己制定的泛型
            #endregion

            #region 知识点二 申明
            //需要引用命名空间 using System.Collections.Generic
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            #endregion

            #region 知识点三 增删查改

            #region 增
            //注意：不能出现相同键
            dictionary.Add(1, "123");
            dictionary.Add(2, "222");
            dictionary.Add(3, "222");
            //dictionary.Add(3, "123");
            #endregion

            #region 删
            //1.只能通过键去删除
            //  删除不存在键 没反应
            dictionary.Remove(1);
            dictionary.Remove(4);

            //2.清空
            dictionary.Clear();
            dictionary.Add(1, "123");
            dictionary.Add(2, "222");
            dictionary.Add(3, "222");
            #endregion

            #region 查
            //1.通过键查看值
            //  找不到直接报错
            Console.WriteLine(dictionary[2]);
            //Console.WriteLine(dictionary[4]);
            Console.WriteLine(dictionary[1]);

            //2.查看是否存在
            //  根据键检测
            if (dictionary.ContainsKey(4))
            {
                Console.WriteLine("存在键为1的键值对");
            }
            //  根据值检测
            if (dictionary.ContainsValue("1234"))
            {
                Console.WriteLine("存在值为123的键值对");
            }

            #endregion

            #region 改
            Console.WriteLine(dictionary[1]);
            dictionary[1] = "555";
            Console.WriteLine(dictionary[1]);
            #endregion

            #endregion

            #region 知识点四 遍历
            Console.WriteLine("**************");
            Console.WriteLine(dictionary.Count);
            //1.遍历所有键
            foreach (int item in dictionary.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(dictionary[item]);
            }
            //2.遍历所有值
            Console.WriteLine("**************");
            foreach (string item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            //3.键值对一起遍历
            Console.WriteLine("**************");
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("键：" + item.Key + "值：" + item.Value);
            }
            #endregion
        }
    }
}
