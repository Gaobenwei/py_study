using System;

namespace CSharp_opp
{
    #region 知识回顾
    // 实例化对象
    // Person 变量名;
    // Person 变量名 = null;
    // Person 变量名 = new Person();
    #endregion

    #region 知识点一 成员变量
    enum E_SexType
    {
        Man,
        Woman,
    }
    //位置结构体
    struct Position
    {

    }
    //宠物类
    class Pet
    {

    }
    class Person
    {
        public string name = "唐老狮";
        public int age;
        public E_SexType sex;
        //如果要在类中申明一个和自己相同类型的成员变量时
        //不能对它进行实例化
        public Person gridFriend;
        public Person[] boyFriend;
        public Position pos;
        private Pet pet = new Pet();
    }
    #endregion

    #region 知识点二 访问修饰符
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");

            Person p = new Person();

            #region 知识点三 成员变量的使用和初始值
            //值类型来说 数字类型 默认值都是0  bool类型 false  
            //引用类型的 null
            //交给大家一个看默认值的小技巧  default(变量类型) 就能得到默认值
            Console.WriteLine(default(Person));

            p.age = 10;
            Console.WriteLine(p.age);
            #endregion
        }
    }
    //总结
    //默认值，值不相同
    //默认值，引用为null
}
