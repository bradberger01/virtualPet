using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class VirtualPet
    {
        private string typeOfPet;
        private string name;
        private int hungerLevel;
        private int energyLevel;
        private int happinessLevel;
    

        //private int whatToDo;

        public string TypeOfPet
        {
            get { return this.typeOfPet; }
            set { this.typeOfPet = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }
        public int EnergyLevel
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }
        public int HappinessLevel
        {
            get { return this.happinessLevel; }
            set { this.happinessLevel = value; }
        }
      
        //public int WhatToDo
        //{
        //    get { return this.whatToDo; }
        //    set { this.whatToDo = value; }
        //}
        public VirtualPet()
        {
            this.name = "James";
            this.typeOfPet = "Monkey";
            this.hungerLevel = 5;
            this.energyLevel = 5;
            this.happinessLevel = 5;
        }
        public VirtualPet(string name, string typeOfPet, int hungerLevel, int energyLevel, int happinessLevel)
        {
            this.name = name;
            this.typeOfPet = typeOfPet;
            this.hungerLevel = hungerLevel;
            this.energyLevel = energyLevel;
            this.happinessLevel = happinessLevel;
        }
        public void Start()
        {
            Console.WriteLine("Your Pet: " + this.Name);
            Console.WriteLine("Type of Pet: " + this.TypeOfPet);
            Console.WriteLine("Energy Level: " + this.EnergyLevel);
            Console.WriteLine("Hunger Level: " + this.HungerLevel);
            Console.WriteLine("Happiness Level: " + this.HappinessLevel);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 Feed {0}", name);
            Console.WriteLine("2 Play with {0}", name);
            Console.WriteLine("3 Let {0} Sleep", name);
            Console.WriteLine("4 Take {0} to the bathroom", name);
            Console.WriteLine("5 Do Nothing");

            //int whatToDo = int.Parse(Console.ReadLine());
        }
        public void Eat()
        {
            if (this.HungerLevel >= 5)
            {
                this.HungerLevel = 5;
                Console.WriteLine("I am not hungry right now. Hunger Level is full");
                Console.WriteLine(" ");
            }
            else if(this.HungerLevel > 2 && this.HungerLevel <= 4)
            {
                this.HungerLevel += 1;
                this.EnergyLevel += 1;
                Console.WriteLine("Yum. That banana did the trick. Hunger level is at {0}.", this.HungerLevel);
                Console.WriteLine(" ");
            }
            else if(this.HungerLevel >= 1 && this.HungerLevel <= 2)
            {
                this.HungerLevel += 1;
                this.EnergyLevel += 1;
                Console.WriteLine("Thanks. I was starving. Hunger level is {0}.", this.HungerLevel);
                Console.WriteLine(" ");
            }
            else if(this.HungerLevel <= 0)
            {
                return;
                //Console.WriteLine("Hunger level is at {0}. I died of starvation. GAME OVER", this.HungerLevel);
            }
        


        }
        public void Play()
        {
            if (this.HappinessLevel >= 5)
            {
                this.HappinessLevel = 5;
                this.EnergyLevel -= 1;
                this.HungerLevel -= 1;
                Console.WriteLine("I am super happy right now. Happiness Level is full");
                Console.WriteLine(" ");
            }
            else if (this.HappinessLevel >= 3 && this.HappinessLevel <= 4)
            {
                this.HappinessLevel += 1;
                this.EnergyLevel -= 1;
                this.HungerLevel -= 1;
                Console.WriteLine("That was fun. Happiness level is at {0}.", this.HappinessLevel);
                Console.WriteLine(" ");
            }
            else if (this.HappinessLevel == 1 && this.HappinessLevel <= 2)
            {
                this.HappinessLevel += 1;
                this.EnergyLevel -= 1;
                this.HungerLevel -= 1;
                Console.WriteLine("Thanks. I was getting bored. Happiness level is {0}.", this.HappinessLevel);
                Console.WriteLine(" ");
            }
            else if(this.HappinessLevel <= 0)
            {
                //Console.WriteLine("Happiness level is at {0}. I died of bordom.", this.happinessLevel);
                return;
            }
        }
        public void Sleep()
        {
            if (this.HappinessLevel < 5 || this.EnergyLevel < 5)
            {
                this.HappinessLevel += 1;
                this.EnergyLevel += 1;
                this.HungerLevel -= 1;
                Console.WriteLine("I am super refreshed but might need some food");
                Console.WriteLine(" ");
            }
            else 
            {
                Console.WriteLine("I don't feel like sleeping. My Happiness level and Energy level are full.");
                Console.WriteLine(" ");
            }
        }
        public void Bathroom()
        {
            if(this.HungerLevel <= 2)
            {
                Console.WriteLine("I don't need to go right now.");
                Console.WriteLine(" ");
            }
            else if(this.HungerLevel > 2 && this.HungerLevel < 5)
            {
                this.HungerLevel -= 1;
                this.EnergyLevel += 1;
                this.HappinessLevel += 1;
                Console.WriteLine("Thanks. I feel better");
                Console.WriteLine(" ");
                    
            }
            else
            {
                this.HungerLevel -= 2;
                this.EnergyLevel += 1;
                this.HappinessLevel += 1;
                Console.WriteLine("Thanks. I really needed to go. Glad I didn't have an accident.");
                Console.WriteLine(" ");
            }
        }
        public void DoNothing()
        {
            if(this.HungerLevel >= 1 || this.EnergyLevel >= 1 || this.HappinessLevel >= 1)
            {
                this.HungerLevel -= 1;
                this.EnergyLevel -= 1;
                this.HappinessLevel -= 1;
            }
            else if(this.HungerLevel == 0 || this.EnergyLevel == 0 || this.HappinessLevel == 0)
            {
                return;
            }
        }



    }
}
