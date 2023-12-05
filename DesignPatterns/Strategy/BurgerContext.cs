using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BurgerContext
    {
        private IBurgerStrategy _burgerStrategy;

        public BurgerContext(IBurgerStrategy strategy)
        {
            _burgerStrategy = strategy;
        }
        public void SetBurgerStrategy(IBurgerStrategy burgerStrategy)
        {
            _burgerStrategy = burgerStrategy;
        }
        public Burger ExecuteBurgerStrategy()
        {
            return _burgerStrategy.Execute();
        }
    }
}
