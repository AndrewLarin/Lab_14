using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Animal
    {
        public abstract string Name { get;set; }

        public Animal()
        {
            Name = "banana";
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}
