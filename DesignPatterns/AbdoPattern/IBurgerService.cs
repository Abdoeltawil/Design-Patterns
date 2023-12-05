namespace DesignPatterns.AbdoPattern
{
    public interface IBurgerService
    {
        Burger AddBuns(Burger burger, int buns);
        Burger AddTomatoes(Burger burger, int tomatoes);
        Burger AddPickles(Burger burger, int pickles);
        Burger AddPatty(Burger burger, int patty);
        Burger AddCheese(Burger burger, int cheese);
        Burger AddOnion(Burger burger, int onion);
        Burger AddLettuce(Burger burger, int lettuce);

    }
}
