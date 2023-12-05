namespace DesignPatterns.BuilderPattern
{
    internal class BurgerBuilder
    {
        int Buns { get; set; } = 2;
        int Tomatoes { get; set; } = 0;
        int Pickles { get; set; } = 0;
        int Patty { get; set; } = 0;
        int Cheese { get; set; } = 0;
        int Onion { get; set; } = 0;
        int Lettuce { get; set; } = 0;

        public BurgerBuilder AddBuns(int buns)
        {
            Buns += buns;
            return this;
        }

        public BurgerBuilder AddTomatoes(int tomatoes)
        {
            Tomatoes += tomatoes;
            return this;
        }

        public BurgerBuilder AddPickles(int pickles)
        {
            Pickles += pickles;
            return this;
        }

        public BurgerBuilder AddPatty(int patty)
        {
            Patty += patty;
            return this;
        }

        public BurgerBuilder AddCheese(int cheese)
        {
            Cheese += cheese;
            return this;
        }

        public BurgerBuilder AddOnion(int onion)
        {
            Onion += onion;
            return this;
        }

        public BurgerBuilder AddLettuce(int lettuce)
        {
            Lettuce += lettuce;
            return this;
        }
        public Burger Build()
        {
            return new Burger(Buns, Tomatoes, Pickles, Patty, Cheese, Onion, Lettuce);
        }
    }

}
