using DesignPatterns.PipeStrategy;

namespace DesignPatterns.PipStrategy
{
    internal class ExtraCheeseStrategy : IPipeLineStep
    {
        public Burger Execute(IPipeLineContext context)
        {
            return new Burger(2, 1, 1, 1, 3, 0, 1);
        }
    }
}
