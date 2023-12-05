using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class ExtraCheeseStrategy : IBurgerStrategy
    {
        public Burger Execute()
        {
            return new Burger(2, 1, 1, 1, 3, 0, 1);
        }
    }
}
