using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ExtraVegetables : IBurgerStrategy
    {
        public Burger Execute()
        {
            return new Burger(2,2,2,1,0,0,2);
        }
    }
}
