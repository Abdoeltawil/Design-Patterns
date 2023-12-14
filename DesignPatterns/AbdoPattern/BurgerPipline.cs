namespace DesignPatterns.AbdoPattern
{
    public class BurgerPipline
    {
        private List<(Func<Burger,int, Burger>,int)> _steps = new List<(Func<Burger, int, Burger>, int)>();
        public BurgerPipline AddStep((Func<Burger, int, Burger>, int) step)
        {
            _steps.Add(step);
            return this;
        }
        public Burger Execute(Burger burger)
        {
            foreach (var step in _steps)
            {
                burger = step.Item1(burger,step.Item2);
            }
            return burger;
        }
    }
}
