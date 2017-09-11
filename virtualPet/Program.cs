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
            //Punky the monkey virtual Pet
            VirtualPet monkey = new VirtualPet("Punky", "Monkey", 5, 5, 5);

            //Loop plays game until energy level, hunger level or happiness level get to 0

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
                else if(whatToDo == 5)
                {
                    monkey.DoNothing();
                }
            }
           //Once loop is broken "Game Over" message returns and program ends

            Console.WriteLine("I DIED FROM NEGLECT. GAME OVER");
            return;
        }
    }
}
