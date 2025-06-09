using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1_test
{
    class MyCustomAttribut : Attribute
    {
        public string Name { get; set; }
    }
    public class Player
    {
        public string name;
        public int blood;
        public int atk;
        [MyCustomAttribut()]
        public int fangyu;
        public int x;
        public int y;
        public Player()
        {
            Console.WriteLine("午餐构造");


        }
    }
}
