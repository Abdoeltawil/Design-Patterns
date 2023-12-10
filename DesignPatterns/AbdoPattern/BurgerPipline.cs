namespace DesignPatterns.AbdoPattern
{
    public class BurgerPipline
    {
        private List<Func<Burger, Burger>> _steps = new List<Func<Burger, Burger>>();
        public BurgerPipline AddStep(Func<Burger, Burger> step)
        {
            _steps.Add(step);
            return this;
        }
        public Burger Execute(Burger burger)
        {
            foreach (var step in _steps)
            {
                burger = step(burger);
            }
            return burger;
        }
    }
}
