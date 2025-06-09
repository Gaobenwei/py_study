namespace ConsoleApp1
{
    #region 知识点一 什么是协变逆变
    //因为 里氏替换原则 父类可以装子类 但是子类不能装父类
    //协变和逆变是用来修饰泛型的
    //协变：out 
    //逆变：in
    //用于在泛型中 修饰 泛型字母的 
    //只有泛型接口和泛型委托能使用
    #endregion

    #region
    //1.返回值 和 参数
    //用out修饰的泛型 只能作为返回值
    //用in修饰的泛型 只能作为参数
    delegate T TestOut<out T>();
    delegate void TestIn<in T>(T t);

    class Father { }
    class Son : Father { }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestOut<Son> os = () => { return new Son(); };
            TestOut<Father> of = os;
            Father f = of();//实际上 返回的 是os里面装的函数 返回的是Son

            TestIn<Father> iF = (value) => { };
            TestIn<Son> iS = iF;
            iS(new Son());//实际上 调用的是 iF
        }
    }
    //总结
    //协变 out
    //逆变 in
    //用来修饰 泛型替代符的  只能修饰接口和委托中的泛型

    //作用两点
    //1.out修饰的泛型类型 只能作为返回值类型 in修饰的泛型类型 只能作为 参数类型
    //2.遵循里氏替换原则的  用out和in修饰的 泛型委托 可以相互装载（有父子关系的泛型）
    //  协变  父类泛型委托装子类泛型委托    逆变 子类泛型委托装父类泛型委托
}
