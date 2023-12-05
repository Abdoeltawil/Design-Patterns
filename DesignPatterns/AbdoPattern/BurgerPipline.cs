using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbdoPattern
{
    public class BurgerPipline
    {
        private List<Func<Burger,int, Burger>> _steps = new List<Func<Burger, int, Burger>>();
        public BurgerPipline AddStep(Func<Burger, int, Burger> step)
        {
            _steps.Add(step);
            return this;
        }
        public Burger Execute(Burger burger,int value)
        {
            foreach (var step in _steps)
            {
                burger = step(burger,value);
            }
            return burger;
        }
    }
}
