using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    abstract class  Animal
    {
        protected string Name { get; set; } 
        protected string Gender { get; set; }
        public abstract int AgeCheck { get; set; }
        public abstract int WeightCheck { get; set; }
        
        public Animal(string name, string gender, int age, int weight)
        {
            Name = name;
            Gender = gender;
            AgeCheck = age;
            WeightCheck = weight;
        }

        
    }
}
