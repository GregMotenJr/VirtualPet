using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Virtual Pet by Greg Moten Jr///

            ///Virtual Pet is a game that you can play where you create any pet you want and do fun/// 
            ///and even silly things like eat pizza and watch netflix together///

            //Note: Decided to add some pauses during the inital set up to make it seem like the computer is thinking


            //Greeting for the user
            Console.WriteLine("Welcome to your Virtual Pet!");
            Console.WriteLine("\n\nWhat is your first name?");
            string usersName = Console.ReadLine();
            System.Threading.Thread.Sleep(0500);
            Console.WriteLine("\nNice to meet you " + usersName);
            Console.WriteLine("\nLets get started!");

            //Let the user choose the type, age and also name the pet
            Console.WriteLine("\n\nWhat kind of pet do you want to have?");
            String vPetType = Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nA {0}, thats a great choice {1}!", vPetType, usersName);

            Console.WriteLine("\nChoose a name for your pet");
            String vPetName = Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n{0}, you got it buddy!", vPetName);

            Console.WriteLine("\nAnd lastly, how old is {0} the {1}", vPetName, vPetType);
            int vPetAge = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGreat, now lets go out and find your {0}", vPetType);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nSearching across the country...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nWow... this is harder then I thought...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nHEY!!!... THERE IT IS!!! Lets get it!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n******Throws PokeBall*****");
            System.Threading.Thread.Sleep(2000);
            //added pokemon ball ascii art
            Console.WriteLine("\n\nMMMMMMMMMMMMMMMNDDD8DNDNMMMMMMMMMMMMMMMM");
            Console.WriteLine("MMMMMMMMMMMN777777777777777DMMMMMMMMMMMM");
            Console.WriteLine("MMMMMMMMN7...77777777777777777DMMMMMMMMM");
            Console.WriteLine("MMMMMMM . .. .777777777777777777NMMMMMMM");
            Console.WriteLine("MMMMMD........:777777777777777777DMMMMMM");
            Console.WriteLine("MMMMO.........777777777777777777777MMMMM");
            Console.WriteLine("MMMD7........77777777777777777777777MMMM");
            Console.WriteLine("MMN7777...7777777777ZZZZZZZD77777777NMMM");
            Console.WriteLine("MM7777777777777777DZZ=....+ZZ77777777MMM");
            Console.WriteLine("MD777777777$NDZZZZZZ.N....N.ZZ7777777DMM");
            Console.WriteLine("M87777NZZZZZZZZZZZZO. ......ZZZZZN7777MM");
            Console.WriteLine("M88ZZZZZZZZZZZZZZZZZ.N....N.ZZZZZZZZZDMM");
            Console.WriteLine("M88ZZZZZZZNN......NZZ, .. :ZZOZZZZZZZZMM");
            Console.WriteLine("M888D?+?...........DZZZZZZZZ......DZZZMM");
            Console.WriteLine("MD??????..............8DD:...........NMM");
            Console.WriteLine("MM+??????............................MMM");
            Console.WriteLine("MMD???????..........................DMMM");
            Console.WriteLine("MMMD???????........................DMMMM");
            Console.WriteLine("MMMMN???????+.....................DMMMMM");
            Console.WriteLine("MMMMMD?????????................??DMMMMMM");
            Console.WriteLine("MMMMMMMD???????????:.......????DMMMMMMMM");
            Console.WriteLine("MMMMMMMMMN???????????????????DMMMMMMMMMM");
            Console.WriteLine("MMMMMMMMMMMMN?????????????NMMMMMMMMMMMMM");
            Console.WriteLine("MMMMMMMMMMMMMMMMMNDDDNMMMMMMMMMMMMMMMMMM");

            Console.WriteLine("\n\n\nGotcha!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nHey Little buddy... Lets take you home :)");
            System.Threading.Thread.Sleep(2000);


            //Create the new pet
            VirtualPet myPet = new VirtualPet(vPetName, 5, 5, vPetAge, vPetType);

            //Menu System
            int selectedOption;


            do
            {
                //Mood variable and if statment for menu
                string vPetSmile = (":)");

                if (myPet.happiness >= 8)
                {
                    vPetSmile = (":)");
                }

                else if (myPet.happiness <= 4)
                {
                    vPetSmile = (":(");
                }

                else
                {
                    vPetSmile = (":|");
                }

                //The Different types of interactions with the pet
                //Left quit on the 10 option instead of 7 so its not accidentally hit by user

                //Tried to add ASCII art of a pokemon ball that would come up but it would not come out to my liking
                //though I suppose I could try to write one line at a time on console writelines
                //I'll add it and comment it out

                //update* got the ASCII art to work by using the idea above but it is to big for what I intended so I will rewrite the ending
                //of the intro and add it there

                //Main Menu
                Console.WriteLine();
                Console.WriteLine("{0} the {1}", vPetName, vPetType);
                Console.WriteLine("Current Mood: {0}", vPetSmile);
                Console.WriteLine("Please select an option");
                Console.WriteLine("\n1. Feed {0}", vPetName);
                Console.WriteLine("2. Walk {0}", vPetName);
                Console.WriteLine("3. Pet {0}", vPetName);
                Console.WriteLine("4. Talk to {0}", vPetName);
                Console.WriteLine("5. Check the stats on {0}", vPetName);
                Console.WriteLine("6. Watch NetFlix with {0}", vPetName);
                Console.WriteLine("10. Quit and release {0} into the wild", vPetName);


                selectedOption = int.Parse(Console.ReadLine());




                switch (selectedOption)
                {
                    //Feed the pet
                    case 1:

                        myPet.HungerIncrease();
                        Console.WriteLine("\n***NOM NOM NOM***");
                        Console.WriteLine("Hunger +5");

                        break;

                    //Walk the pet
                    case 2:

                        myPet.walk();
                        Console.WriteLine("\nYou take {0} out for a nice walk through nature", myPet.name);
                        Console.WriteLine("Happiness +3\nHunger -2");

                        break;

                    //pet to the pet
                    case 3:

                        myPet.pet();
                        Console.WriteLine("\n{0} comes up to you and you pet them", myPet.name);
                        Console.WriteLine("Happiness +5");

                        break;

                    //Talk to the pet
                    case 4:

                        myPet.talk();
                        Console.WriteLine("\n{0} seems happy with your concern", myPet.type, myPet.name);
                        Console.WriteLine("Happiness +3");

                        break;

                    //check stats
                    case 5:

                        myPet.MyPetStatus();
                        break;

                    //Watch Netflix
                    case 6:

                        myPet.netflix();
                        Console.WriteLine("\nYou and {0} sit back and enjoy pizza together while bing watching bob burgers", myPet.name);
                        Console.WriteLine("Happiness +10\nHunger +10");

                        break;

                    //Quit
                    case 10:
                        Console.WriteLine("\nReleasing {0} back into the wild to be happy and free", myPet.name);
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("\nThanks for playing {0}!", usersName);
                        Console.ReadKey();
                        break;

                    default:

                        Console.WriteLine("\nInvalid option selected.");
                        break;
                }

                //Auto value decrease
                myPet.HungerDecrease();
                myPet.HappinessDecrease();
                myPet.age++;

                //Perma-Death/Instant Game Over Condition
                if (myPet.hunger < 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\nYour pet {0} the {1} just died of starvation :'(", myPet.name, myPet.type);
                    Console.WriteLine("poor {0} :'(", myPet.name);
                    Console.WriteLine("\nWe will now observe a moment of silence for the once magnificent {0}... {1}", myPet.type, myPet.name);
                    //3 second moment of silence 
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("\n\nGAME OVER");
                    Console.ReadKey();
                    break;
                }

                else if (myPet.happiness < 1)
                {
                    Console.Clear();
                    Console.WriteLine("\n\nYour pet {0} the {1} litterly just died of a broken heart :'(", myPet.name, myPet.type);
                    Console.WriteLine("I... I can't... I just cant anymore :'( :'( :'(");
                    Console.WriteLine("\nWe will now observe a moment of silence for the once magnificent {0}... {1}", myPet.type, myPet.name);
                    //3 second moment of silence
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("\n\nGAME OVER");
                    Console.ReadKey();
                    break;
                }

                else
                {
                    continue;
                }

            } while (selectedOption != 10);

        }
    }
}