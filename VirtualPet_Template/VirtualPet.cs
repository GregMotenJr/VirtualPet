using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{

    class VirtualPet
    {
        //Fields for the VirtualPet 
        public string name;
        public int hunger;
        public int happiness;
        public int age;
        public string type;



        //Defaut constructor
        public VirtualPet()
        {
            this.name = "Billy";
            this.hunger = 20;
            this.happiness = 5;
            this.age = 1;
            this.type = "Dog";

        }
        //Primary constructor
        public VirtualPet(string name, int hunger, int happiness, int age, string type)
        {
            this.name = name;
            this.hunger = hunger;
            this.happiness = happiness;
            this.age = age;
            this.type = type;
        }


        //This method can be called to increase the hunger
        public void HungerIncrease()
        {
            this.hunger = hunger + 5;
        }

        //This method can be called to decrease the hunger
        public void HungerDecrease()
        {
            this.hunger = hunger - 1;
        }

        //This method can be called to decrease the happiness
        public void HappinessDecrease()
        {
            this.happiness = happiness - 1;
        }

        //Method to talk to your pet - dual function: status check and interactive activity
        public void talk()
        {
            happiness = happiness + 3;
            Console.WriteLine("You look at {0} the {1} and ask how they are feeling in a calm and plesent tone", name, type);

            if (happiness > 7)
            {
                Console.WriteLine("\n{0} looks at you with pure joy!", name);
            }
            else if (happiness == 4 && happiness >= 7)
            {
                Console.WriteLine("\n{0} looks at you with mild contentness", name);
            }
            else
            {
                Console.WriteLine("\n{0} looks at you, looking like it is ready to bust into tears... why... why", name);
            }



            if (hunger > 9)
            {
                Console.WriteLine("So happy and so content, they just fall asleep without a care in the world");
            }
            else if (hunger == 4 && hunger <= 8)
            {
                Console.WriteLine("{0} looks at you but you cant really tell if they are looking at you or your bag of tacos", name);
            }
            else
            {
                Console.WriteLine("{0} looks like they are on deaths door! Better do something quick!", name);
            }
        }


        // Method to pet your pet 
        public void pet()
        {
            happiness = happiness + 5;
        }

        // Method to walk the pet
        public void walk()
        {
            happiness = happiness + 3;
            hunger = hunger - 2;
        }

        // Method to watch netflix with your pet
        public void netflix()
        {
            happiness = happiness + 10;
            hunger = hunger + 10;
        }

        // Method for checking full stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name + " the " + type);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Happiness: " + happiness);

        }
    }
}
