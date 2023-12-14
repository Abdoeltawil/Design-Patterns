using DesignPatterns.PipeStrategy;

namespace DesignPatterns.PipStrategy
{
    public class ExtraBeefBurgerStrategy : IPipeLineStep
    {
        public Burger Execute(IPipeLineContext context)
        {
            return new Burger(2, 1, 1, 3, 1, 1, 1);
        }

    }
}
