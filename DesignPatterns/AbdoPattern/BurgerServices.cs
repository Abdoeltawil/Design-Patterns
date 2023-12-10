namespace DesignPatterns.AbdoPattern
{
    public class BurgerServices : IBurgerService
    {
        public Burger AddBuns(Burger burger)
        {
            burger.Buns++;
            return burger;
        }

        public Burger AddTomatoes(Burger burger)
        {
            burger.Tomatoes++;
            return burger;
        }

        public Burger AddPickles(Burger burger)
        {
            burger.Pickles++;
            return burger;
        }

        public Burger AddPatty(Burger burger)
        {
            burger.Patty++;
            return burger;
        }

        public Burger AddCheese(Burger burger)
        {
            burger.Cheese++;
            return burger;
        }

        public Burger AddOnion(Burger burger)
        {
            burger.Onion++;
            return burger;
        }

        public Burger AddLettuce(Burger burger)
        {
            burger.Lettuce++;
            return burger;
        }
    }
}
