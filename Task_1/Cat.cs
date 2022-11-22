using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Cat:Animal
    {
    private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу"); ;
        }
    }
}
