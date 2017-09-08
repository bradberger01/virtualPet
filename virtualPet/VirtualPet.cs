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

        public string TypeOfPet
        {
            set { this.typeOfPet = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HungerLevel
        {
            set { this.hungerLevel = value; }
        }
        public int EnergyLevel
        {
            set { this.energyLevel = value; }
        }
        public int HappinessLevel
        {
            set { this.happinessLevel = value; }
        }
        public VirtualPet()
        {
            this.name = "James";
            this.typeOfPet = "Monkey";
            this.hungerLevel = 1;
            this.energyLevel = 5;
            this.happinessLevel = 5;

        }

    }
}
