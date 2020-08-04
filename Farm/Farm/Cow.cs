using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Cow : Animal, IEat
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
                if (value > 20 || value < 0)
                    Console.WriteLine("Your cow is old or you entered age less than 0");
            }
        }
        public override int WeightCheck
        {
            get => _weight;
            set
            {
                if (value > 850 || value < 0)
                    Console.WriteLine("Your cow's weight is too big or you entered weight less than 0");
            }
        }

        public Cow(string name, string gender, int age, int weight) : base(name, gender, age, weight)
        {
            Age = age;
            Name = name;
            Gender = gender;
            Weight = weight;
        }
        
        public void Eat()
        {
            Console.WriteLine("Cows eat grass");

        }

    }
}
