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
            WriteLine(spot.FunFact());

            WriteLine(puff);
            WriteLine(puff.FunFact());

           //WriteLine(snow);
            WriteLine(snow.FunFact());

            //WriteLine(happy);
            WriteLine(happy.FunFact());

            WriteLine(tony.FunFact());
            WriteLine(king.FunFact());


        }
    }

    enum Diet { HERBIVORES, CARNIVORES, OMNIVORES };

    // string[] <<-- included as part of the language

    abstract class Animal
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

        public abstract string FunFact();
    }

    abstract class Canine : Animal
    {
        public abstract override string FunFact();
    }

    abstract class Feline : Animal
    {
        public abstract override string FunFact();
    }


    interface IPet
    {
        string VaccinationDate { get; set; }
    }


    class Dog : Canine, IPet
    {
        public override string FunFact()
        {
            //return "Dog has successfully buried a bone.";
            return "Dogs love to bury bones in the yard.";
        }
        public string VaccinationDate { get; set; }
    }

    class Cat : Feline, IPet
    {
        public override string FunFact()
        {
            //return "Cat chased the mouse away!";
            return "Cats love to chase mice";
        }

        public string VaccinationDate { get; set; }
    }

    class Wolf : Animal
    {
        public override string FunFact()
        {
            return "Wolf howl at the full moon.";
        }
    }

    class Hippo : Animal
    {
        public override string FunFact()
        {
            return "Hippopotamus love to bathes in the cool mud.";
        }
    }

    class Tiger : Animal
    {
        public override string FunFact()
        {
            return "The tiger is the biggest species of the cat family.";
        }
    }

    class Lion : Animal
    {
        public override string FunFact()
        {
            return "The roar of a lion can be heard from 5 miles away.";
        }
    }
}
