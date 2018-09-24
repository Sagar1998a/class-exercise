using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public int animal { get; set; }
        string name, sound;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public Animal(string _name, string _sound)
        {
            Name = _name;
            Sound = _sound;
        }

        public string AnimalSays()
        {
            return "The " + Name + " says " + Sound;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the animals type ie. Cow, dog, cat: ");
            string animalType = Console.ReadLine();
            Console.Write("Please enter the sound the animal makes: ");
            string animalSound = Console.ReadLine();
            Animal animal1 = new Animal(animalType, animalSound);
            Console.WriteLine(animal1.AnimalSays());
        }
    }
}

    