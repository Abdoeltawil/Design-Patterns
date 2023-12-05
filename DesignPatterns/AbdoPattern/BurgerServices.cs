using DesignPatterns.BuilderPattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbdoPattern
{
    public class BurgerServices : IBurgerService
    {
        public Burger AddBuns(Burger burger,int buns)
        {
            burger.Buns += buns;
            return burger;
        }

        public Burger AddTomatoes(Burger burger, int tomatoes)
        {
            burger.Tomatoes += tomatoes;
            return burger;
        }

        public Burger AddPickles(Burger burger, int pickles)
        {
            burger.Pickles += pickles;
            return burger;
        }

        public Burger AddPatty(Burger burger, int patty)
        {
            burger.Patty += patty;
            return burger;
        }

        public Burger AddCheese(Burger burger, int cheese)
        {
            burger.Cheese += cheese;
            return burger;
        }

        public Burger AddOnion(Burger burger, int onion)
        {
            burger.Onion += onion;
            return burger;
        }

        public Burger AddLettuce(Burger burger, int lettuce)
        {
            burger.Lettuce += lettuce;
            return burger;
        }
    }
}
