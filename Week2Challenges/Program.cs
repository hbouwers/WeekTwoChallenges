using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeting = new Greeter();
            greeting.Hello("Holden");
            greeting.Farewell("Holden");
            greeting.PropHello();
            greeting.PropFarewell();
            greeting.Time();
            Console.ReadLine();
        }
    }
}
