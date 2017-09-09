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

            while (monkey.EnergyLevel > 0 && monkey.HappinessLevel > 0 && monkey.HungerLevel > 0)
            {
                monkey.Start();
                Console.WriteLine(" ");
               int whatToDo = int.Parse(Console.ReadLine());
                if (whatToDo == 1)
                {
                    monkey.Eat();
                }
                else if(whatToDo == 2)
                {
                    monkey.Play();
                }
                else if(whatToDo == 3)
                {
                    monkey.Sleep();
                }
                else if(whatToDo == 4)
                {
                    monkey.Bathroom();
                }
            }
            Console.WriteLine("GAME OVER");
        }
    }
}
