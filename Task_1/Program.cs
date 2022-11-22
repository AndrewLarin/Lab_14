using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Name = "Вася";
            dog.Name = "Бася";
            cat.ShowInfo();
            dog.ShowInfo();
        }
    }
}
