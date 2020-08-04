using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Horses : Animal, IEat
    {
        private int _age;
        private int _weight;
        public string Name;
        public string Gender;
        public int Age;
        public int Weight;
        public override int AgeCheck
        {
            get => _age;
            set
            {
                if (value > 30 || value < 0) 
                    Console.WriteLine("Your horse is old or you entered age less than 0"); 
            }
        }
        public override int  WeightCheck 
        { 
            get => _weight; 
            set 
            { if (value > 740 || value < 0) 
                    Console.WriteLine("Your horse's weight is too big or you entered weight less than 0"); 
            } 
        }        


        public Horses(string name, string gender, int age, int weight) : base (name, gender, age, weight)
        {
            Age = age;
            Name = name;
            Gender = gender;
            Weight = weight;
        }

        
        public void Eat()
        {
            Console.WriteLine("Horses eat grass");
            
        }

        
    }
}
