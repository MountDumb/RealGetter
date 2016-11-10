using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Thingies thing = new Thingies();
            Console.WriteLine(thing.i);
            Console.WriteLine(thing.s);
            thing.DoStuff();
            Thingy th = new Thingy();
            Console.WriteLine(th.i);
            Console.ReadLine();    
        }
    }

    public class Thingy
    {
        public int i;
        public Thingy()
        {
            i = 0;
        }

        public void DoStuff()
        {
            Console.WriteLine("arglebargle");
        }

    }

    public class Thingies : Thingy
    {
        public string s = "erggdgdgdg";
    }
}
