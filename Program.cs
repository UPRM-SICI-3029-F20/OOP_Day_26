using System;
using static System.Console;

namespace OOP_Day_26
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("OOP Day #26");
            // Usual way to create object
            Dog spot = new Dog();  // Dog object or instance of Dog
            spot.Name = "Kia";
            spot.Sound = "woof woof";
            spot.Age = 3;
            spot.Color = "Black";
            spot.Diet = Diet.CARNIVORES;
            // Alternate (simplified) way
            Cat puff = new Cat
            {
                Name = "Puffy",
                Sound = "meow meow",
                Age = 2,
                Color = "White and Yellow",
                Diet = Diet.OMNIVORES
            };
            Wolf snow = new Wolf();
            Hippo happy = new Hippo();
            Tiger tony = new Tiger();
            Lion king = new Lion();
            //Animal fulano = new Animal();

            WriteLine(spot);
            WriteLine(spot.BuryBone());

            WriteLine(puff);
            WriteLine(puff.ChaseMouse());

           //WriteLine(snow);
            WriteLine(snow.WolfHowls());

            //WriteLine(happy);
            WriteLine(happy.HippoBath());

            WriteLine(tony.TigerFact());
            WriteLine(king.LionFact());


        }
    }

    enum Diet { HERBIVORES, CARNIVORES, OMNIVORES };

    // string[] <<-- included as part of the language

    class Animal
    {
        // Properties, attrributes, fields, 
        public string Name { get; set; }  // setter & getters
        public int Age { get; set; }
        public string Color { get; set; }
        public Diet Diet { get; set; }
        public string Sound { get; set; }
        public string Id { get; set; }
        public string Owner { get; set; }


        // Methods, Functions, Behaviours 
        public override string ToString()
        {
            return "Name:" + Name +
                   "  Color:" + Color +
                   "  Age:" + Age +
                   "  Diet:" + Diet;
        }
    }

    class Dog : Animal
    {
        public string BuryBone()
        {
            return "Dog has successfully buried a bone.";
        }

    }

    class Cat : Animal
    {
        public string ChaseMouse()
        {
            return "Cat chased the mouse away!";
        }
    }

    class Wolf : Animal
    {
        public string WolfHowls()
        {
            return "Wolf howls at the full moon.";
        }
    }

    class Hippo : Animal
    {
         public string HippoBath()
        {
            return "Hippopotamus bathes in the cool mud.";
        }
    }

    class Tiger : Animal
    {
        public string TigerFact()
        {
            return "The tiger is the biggest species of the cat family.";
        }
    }

    class Lion : Animal
    {
        public string LionFact()
        {
            return "The roar of a lion can be heard from 5 miles away.";
        }
    }
}
