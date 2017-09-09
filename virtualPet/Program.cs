using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet monkey = new VirtualPet();
            monkey.Start();

           int whatToDo = int.Parse(Console.ReadLine());
        }
    }
}
