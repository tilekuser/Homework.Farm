using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class Farmm
    {
        List<Horses> horse = new List<Horses>();
        List<Sheep> sheep = new List<Sheep>();
        List<Cow> cow = new List<Cow>();
       
        string Name;
        string Address;
        public Farmm(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void FullInfo()
        {
            Console.WriteLine($"\nFarm name: {Name}, Location: {Address}");
            sheep.Add(new Sheep("Kochkor", "Male", 5, 30));
            foreach (var infoSheep in sheep)
            {
                if (infoSheep.Age > 10 || infoSheep.Weight > 45) return;
                else
                    Console.WriteLine($"Sheep name: {infoSheep.Name}, sheep gender: {infoSheep.Gender}, sheep age: {infoSheep.Age}, sheep weight:{infoSheep.Weight}");
                
            }

            horse.Add(new Horses("Aigyr", "Male", 10, 650));
            foreach (var infoHorse in horse)
            {
                if (infoHorse.Age > 30 || infoHorse.Weight > 740) return;
                else
                    Console.WriteLine($"Horse name: {infoHorse.Name}, horse gender: {infoHorse.Gender}, horse age: {infoHorse.Age}, horse weight: {infoHorse.Weight}");
            }

            cow.Add(new Cow("Buka", "Male", 20, 800));
            foreach (var infoCow in cow)
            {
                if (infoCow.Age > 20 || infoCow.Weight > 850) return;
                else
                    Console.WriteLine($"Cow name: {infoCow.Name}, cow gender: {infoCow.Gender}, cow age: {infoCow.Age}, cow weight: {infoCow.Weight}");
            }
        }
        public void AddHorse()
        {
            Console.WriteLine("\nWrite in order Name => gender => age => weight!");
            horse.Add(new Horses(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            FullInfo();
        }
        public void AddCow()
        {
            Console.WriteLine("\nWrite in order Name => gender => age => weight!");
            cow.Add(new Cow(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            FullInfo();
        }
        public void AddSheep()
        {
            Console.WriteLine("\nWrite in order Name => gender => age => weight!");
            sheep.Add(new Sheep(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            FullInfo();
        }
        public void AddAny()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Who do you want to add? => \"sheep?\" \"cow?\" \"horse?\"");
            var input = Console.ReadLine();
            switch (input)
            {
                case "cow":
                    AddCow(); break;
                case "horse":
                    AddHorse(); break;
                case "sheep":
                    AddSheep(); break;
                default:
                    Console.WriteLine("\nWrong wrote"); break;
            }   
        }
    }
}
