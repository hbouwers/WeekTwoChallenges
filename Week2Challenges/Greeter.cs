using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Greeter
    {
        public string Name { get; set; }

        public Greeter() { }

        public Greeter(string name)
        {
            Name = name;
        }
        public void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void PropHello()
        {
            if(Name == null)
            {
                Console.WriteLine("What is your name?");
                Name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {Name}");
        }

        public void Farewell(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }

        public void PropFarewell()
        {
            if (Name == null)
            {
                Console.WriteLine("What is your name?");
                Name = Console.ReadLine();
            }
                Console.WriteLine($"Goodbye {Name}");

        }

        public void Time()
        {
            DateTime now = DateTime.Now;
            if(now.TimeOfDay < TimeSpan.FromHours(12))
            {
                Console.WriteLine("Good Morning");
            }
            else if(now.TimeOfDay < TimeSpan.FromHours(17))
            {
                Console.WriteLine("Good Afternoon");
            }
            else if(now.TimeOfDay < TimeSpan.FromHours(20))
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
