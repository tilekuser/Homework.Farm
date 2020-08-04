using System;

namespace Farm
{
    class Sheep : Animal, IEat
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
                if (value > 10 || value < 0)
                    Console.WriteLine("Your sheep is old or you entered age less than 0");
            }
        }
        public override int WeightCheck
        {
            get => _weight;
            set
            {
                if (value > 45 || value < 0)
                    Console.WriteLine("Your sheep's weight is too big or you entered weight less than 0");
            }
        }

        public Sheep(string name, string gender, int age, int weight) : base(name, gender, age, weight)
        {
            Age = age;
            Name = name;
            Gender = gender;
            Weight = weight;
        }
        public void Eat()
        {
            Console.WriteLine("Sheeps eat grass");

        }


    }
}
