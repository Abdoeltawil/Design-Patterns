using DesignPatterns.PipeStrategy;

namespace DesignPatterns.PipStrategy
{
    public class ExtraVegetables : IPipeLineStep
    {
        public Burger Execute(IPipeLineContext context)
        {
            return new Burger(2, 2, 2, 1, 0, 0, 2);
        }
    }
}
