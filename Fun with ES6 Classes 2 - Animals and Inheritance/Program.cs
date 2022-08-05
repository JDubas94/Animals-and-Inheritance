using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_with_ES6_Classes_2___Animals_and_Inheritance
{
    public class Animal
    {
        public int Age;
        public int Legs;
        public string Name;
        public string Species;
        public string Status;

        public Animal(string name, int age, int legs, string species, string status)
        {
            this.Name = name;
            this.Age = age;
            this.Legs = legs;
            this.Species = species;
            this.Status = status;
        }

        public virtual string Introduce()
        {
            return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
        }
    }
    class Shark : Animal
    {       
         private const int _Legs = 0;
         private const string _Species = "Shark";
        public  Shark(string name, int age,  string status) : base(name, age, _Legs,  status, _Species ) 
        {
            Name = name;
            Age = age;
            Status = status;
        }
    }
    class Cat : Animal
    {
        private const int _legs = 4;
        private const string _species = "Cat";
        public Cat(string name, int age, string status) : base(name, age, _legs, status, _species)
        {
            Name = name;
            Age = age;
            Status = status;
        }

        public override string Introduce()
        {
            string meow = "  Meow meow!";

            return base.Introduce() + meow;
        }
    }
    class Dog : Animal
    {
        private const int _legs = 4;
        private const string _species = "Dog";
        public string Master;
        
        public Dog(string name, int age, string status,string master) : base(name, age, _legs, status, _species)
        {
            Name = name;
            Age = age;
            Status = status;
            Master = master;
        }

        public void GreetMaster()
        {
            Console.WriteLine("Hello " + Master);
    }


    class Program
    {
        static void Main(string[] args)
        {            
            

            Cat cat = new Cat("Bob", 4, "love hom animal");

            Console.WriteLine(cat.Introduce());
            
        }
    }
}
