using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;


namespace igme201FinalRedo
{
    public class Food
    {
        public string Name {get; set;}
        public double Price {get; set;}
        public int Cals {get; set;}

        public Food(string name, double price, int calories)
        {
            Name = name;
            Price = price;
            Cals = calories;
        }
        public override string ToString()
        {
            return $"Food: {Name} - ${Price:F2}, {Cals} calories";
        }
    }

    public class Drink : Food
    {
        public int Ounces {get; set;}

        public Drink(string name, double price, int calories, int ounces) : base(name, price, calories)
        {
            Ounces = ounces;
        }

        public override string ToString()
        {
            return $"Drink: {Name} - ${Price:F2}, {Cals} calories, {Ounces}oz";
        }
    }
}
