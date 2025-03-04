using System;
//namespace Lesson22_面向对象相关_万物之父中的方法
//{
//    class Test
//    {
//        public int i = 1;
//        public Test2 t2 = new Test2();

//        public Test Clone()
//        {
//            return MemberwiseClone() as Test;
//        }

//        public override bool Equals(object obj)
//        {
//            return base.Equals(obj);
//        }

//        public override int GetHashCode()
//        {
//            return base.GetHashCode();
//        }

//        public override string ToString()
//        {
//            return "唐老狮申明的Test类";
//        }
//    }
//    class Test2
//    {
//        public int i = 2;
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("万物之父中的方法");

//            #region 知识回顾
//            //万物之父 object
//            //所有类型的基类 是一个引用类型
//            //可以利用里氏替换原则装载一切对象
//            //存在装箱拆箱
//            #endregion

//            #region 知识点一 object中的静态方法 
//            //静态方法 Equals 判断两个对象是否相等
//            //最终的判断权，交给左侧对象的Equals方法，
//            //不管值类型引用类型都会按照左侧对象Equals方法的规则来进行比较
//            Console.WriteLine(Object.Equals(1, 1));
//            Console.WriteLine(object.Equals(1, 3));
//            Test t_ = new Test();
//            Test t2_ = new Test();
//            Console.WriteLine(Object.Equals(t_, t2_));
//            //静态方法ReferenceEquals
//            //比较两个对象是否是相同的引用，主要是用来比较引用类型的对象。
//            //值类型对象返回值始终是false。
//            Console.WriteLine(object.ReferenceEquals(1, 1));
//            Console.WriteLine(object.ReferenceEquals(t_, t2_));

//            #endregion

//            #region 知识点二 object中的成员方法
//            //普通方法GetType
//            //该方法在反射相关知识点中是非常重要的方法，之后我们会具体的讲解这里返回的Type类型。
//            //该方法的主要作用就是获取对象运行时的类型Type，
//            //通过Type结合反射相关知识点可以做很多关于对象的操作。
//            Test t = new Test();
//            Type type = t.GetType();
//            //普通方法MemberwiseClone
//            //该方法用于获取对象的浅拷贝对象，口语化的意思就是会返回一个新的对象，
//            //但是新对象中的引用变量会和老对象中一致。值变量似乎会重新创建。
//            Test t2 = t.Clone();
//            Console.WriteLine("克隆对象后");
//            Console.WriteLine("t.i = " + t.i);
//            Console.WriteLine("t.t2.i = " + t.t2.i);
//            Console.WriteLine("t2.i = " + t2.i);
//            Console.WriteLine("t2.t2.i = " + t2.t2.i);

//            t2.i = 20;
//            t2.t2.i = 21;
//            Console.WriteLine("改变克隆体信息后");
//            Console.WriteLine("t.i = " + t.i);
//            Console.WriteLine("t.t2.i = " + t.t2.i);
//            Console.WriteLine("t2.i = " + t2.i);
//            Console.WriteLine("t2.t2.i = " + t2.t2.i);
//            #endregion

//            #region 知识点三 object中的虚方法
//            //虚方法Equals
//            //默认实现还是比较两者是否为同一个引用，即相当于ReferenceEquals。
//            //但是微软在所有值类型的基类System.ValueType中重写了该方法，用来比较值相等。
//            //我们也可以重写该方法，定义自己的比较相等的规则

//            //虚方法GetHashCode
//            //该方法是获取对象的哈希码
//            //（一种通过算法算出的，表示对象的唯一编码，不同对象哈希码有可能一样，具体值根据哈希算法决定），
//            //我们可以通过重写该函数来自己定义对象的哈希码算法，正常情况下，我们使用的极少，基本不用。

//            //虚方法ToString
//            //该方法用于返回当前对象代表的字符串，我们可以重写它定义我们自己的对象转字符串规则，
//            //该方法非常常用。当我们调用打印方法时，默认使用的就是对象的ToString方法后打印出来的内容。


//            Console.WriteLine(t);
//            #endregion
//        }
//    }

//    //总结
//    //1.虚方法 toString 自定字符串转换规则
//    //2.成员方法 GetType 反射相关
//    //3.成员方法 MemberwiseClone 浅拷贝
//    //4.虚方法 Equals 自定义判断相等的规则
//}

//namespace Lesson23_面向对象相关_string
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("string");

//            #region 知识点一 字符串指定位置获取
//            //字符串本质是char数组
//            string str = "唐老狮";
//            Console.WriteLine(str[0]);
//            //转为char数组
//            char[] chars = str.ToCharArray();
//            char[] chars_=str.ToCharArray();
//            Console.WriteLine(chars[1]);

//            for (int i = 0; i < str.Length; i++)
//            {
//                Console.WriteLine(str[i]);
//            }
//            #endregion

//            #region 知识点二 字符串拼接
//            str = string.Format("{0}{1}", 1, 3333);
//            string str_ =string.Format("{0}{1}", 1, 3333);
//            Console.WriteLine(str);
//            #endregion

//            #region 知识点三 正向查找字符位置
//            str = "我是唐老狮！";
//            int index = str.IndexOf("唐");
//            int index_ = str.IndexOf("老");
//            Console.WriteLine(index_);
//            Console.WriteLine(index);

//            index = str.IndexOf("吊");
//            Console.WriteLine(index);
//            #endregion

//            #region 知识点四 反向查找指定字符串位置
//            str = "我是唐老狮唐老狮";

//            index = str.LastIndexOf("唐老狮");
//            Console.WriteLine(index);

//            index = str.LastIndexOf("唐老师");
//            Console.WriteLine(index);
//            #endregion

//            #region 知识点五 移除指定位置后的字符
//            str = "我是唐老狮唐老狮";
//            str_ = str.Remove(3);
//            Console.WriteLine(str_);
//            str.Remove(4);
//            Console.WriteLine(str);
//            str = str.Remove(4);
//            Console.WriteLine(str);

//            //执行两个参数进行移除
//            //参数1 开始位置
//            //参数2 字符个数
//            str = str.Remove(1, 1);
//            Console.WriteLine(str);
//            #endregion

//            #region 知识点六 替换指定字符串
//            str = "我是唐老狮唐老狮";
//            str.Replace("唐老狮", "老炮儿");
//            Console.WriteLine(str);
//            str = str.Replace("唐老狮", "老炮儿");
//            Console.WriteLine(str);
//            str_ = str.Replace("我是", "我是你爹");
//            Console.WriteLine(str_);
//            #endregion

//            #region 知识点七 大小写转换
//            str = "ksdfasdfasfasdfsasdfasdf";
//            str.ToUpper();
//            Console.WriteLine(str);
//            str = str.ToUpper();
//            Console.WriteLine(str);

//            str.ToLower();
//            Console.WriteLine(str);
//            str = str.ToLower();
//            Console.WriteLine(str);
//            #endregion

//            #region 知识点八 字符串截取
//            str = "唐老狮唐老狮";
//            //截取从指定位置开始之后的字符串
//            str.Substring(2);
//            Console.WriteLine(str);
//            str = str.Substring(2);
//            Console.WriteLine(str);

//            //参数一 开始位置
//            //参数二 指定个数
//            //不会自动的帮助你判断是否越界 你需要自己去判断
//            str = str.Substring(2, 2);
//            Console.WriteLine(str);
//            #endregion

//            #region 知识点九 字符串切割
//            str = "1_1|2_2|3_3|5_1|6_1|7_2|8_3";
//            string[] strs = str.Split('|');
//            string[] strs_ = str.Split("_");
//            for (int i = 0; i < strs.Length; i++)
//            {
//                Console.WriteLine(strs[i]);
//            }
//            for (int i = 0; i < strs_.Length; i++)
//            {
//                Console.WriteLine(strs_[i]);
//            }
//            #endregion
//        }
//    }
//}

using System;
using System.Text;

namespace Lesson24_面向对象相关_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识回顾
            //string是特殊的引用
            //每次重新赋值或者拼接时会分配新的内存空间
            //如果一个字符串经常改变会非常浪费空间
            #endregion

            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共类 
            //主要解决的问题是：
            //修改字符串而不创建新的对象,需要频繁修改和拼接的字符串可以使用它，可以提升性能
            //使用前 需要引用命名空间

            #region 初始化 直接指明内容
            StringBuilder str = new StringBuilder("123123123");
            System.Text.StringBuilder str_ = new StringBuilder("123132131",50);
            Console.WriteLine(str);
            #endregion

            #region 容量
            //StringBuilder存在一个容量的问题，每次往里面增加时 会自动扩容
            //获得容量
            Console.WriteLine(str.Capacity);
            //获得字符长度
            Console.WriteLine(str.Length);
            Console.WriteLine(str_.Length);
            Console.WriteLine(str_.Capacity);
            #endregion

            #region 增删查改替换
            //增
            str.Append("4444");
            str_.Append("4444");
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str_);
            Console.WriteLine(str_.Length);
            Console.WriteLine(str_.Capacity);

            str.AppendFormat("{0}{1}", 100, 999);
            str_.AppendFormat("{0},{1}", 50, "**");
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str_);
            Console.WriteLine(str_.Length);
            Console.WriteLine(str_.Capacity);
            //插入
            str.Insert(0, "唐老狮");
            Console.WriteLine(str);
            //删
            str.Remove(0, 10);
            Console.WriteLine(str);
            //清空
            //str.Clear();
            //Console.WriteLine(str);
            //查
            Console.WriteLine(str[1]);
            //改
            str[0] = 'A';
            Console.WriteLine(str);
            //替换
            str.Replace("1", "唐");
            str.Replace("00", "+");
            Console.WriteLine(str);

            //重新赋值 StringBuilder
            str.Clear();
            str.Append("123123");
            Console.WriteLine(str);
            //判断StringBuilder是否和某一个字符串相等
            if(str.Equals(str_))
            {
                Console.WriteLine("相等");
            }
            if (str.Equals("12312"))
            {
                Console.WriteLine("相等");
            }
            #endregion

            #endregion
        }
    }
}
