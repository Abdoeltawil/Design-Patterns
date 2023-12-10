namespace DesignPatterns.AbdoPattern
{
    public interface IBurgerService
    {
        Burger AddBuns(Burger burger);
        Burger AddTomatoes(Burger burger);
        Burger AddPickles(Burger burger);
        Burger AddPatty(Burger burger);
        Burger AddCheese(Burger burger);
        Burger AddOnion(Burger burger);
        Burger AddLettuce(Burger burger);

    }
}
