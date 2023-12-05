using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Burger
    {
        public int Buns { get; set; } = 0;
        public int Tomatoes { get; set; } = 0;
        public int Pickles { get; set; } = 0;
        public int Patty { get; set; } = 0;
        public int Cheese { get; set; } = 0;
        public int Onion { get; set; } = 0;
        public int Lettuce { get; set; } = 0;
        public Burger() { }
        public Burger(int buns, int tomatoes, int pickles, int patty, int cheese, int onion, int lettuce)
        {
            Buns = buns;
            Tomatoes = tomatoes;
            Pickles = pickles;
            Patty = patty;
            Cheese = cheese;
            Onion = onion;
            Lettuce = lettuce;
        }

        public void ShowBurger()
        {
            Console.WriteLine("This Burger Has :");
            Console.WriteLine($"{Tomatoes} Tomatoes");
            Console.WriteLine($"{Pickles} Pickles");
            Console.WriteLine($"{Patty} Patty");
            Console.WriteLine($"{Cheese} Cheese");
            Console.WriteLine($"{Onion} Onion");
            Console.WriteLine($"{Lettuce} Lettuce");
        }


    }
}
