namespace DesignPatterns.AbdoPattern
{
    public interface IBurgerService
    {
        Burger AddBuns(Burger burger,int buns);
        Burger AddTomatoes(Burger burger,int tomato);
        Burger AddPickles(Burger burger,int pickle);
        Burger AddPatty(Burger burger,int patty);
        Burger AddCheese(Burger burger,int cheese);
        Burger AddOnion(Burger burger,int onion);
        Burger AddLettuce(Burger burger,int lettuce);

    }
}
