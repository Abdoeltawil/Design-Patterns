using DesignPatterns.AbdoPattern;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            #region BuilderPattern
            //BurgerBuilder builder = new BurgerBuilder();
            //var burger = builder.AddPatty(4).AddBuns(1)
            //                           .AddCheese(3).AddLettuce(1)
            //                           .AddOnion(2).Build();
            // burger.ShowBurger();
            #endregion

            #region StrategyPattern
            //BurgerContext burger = new BurgerContext(new ExtraCheeseStrategy());
            //var result = burger.ExecuteBurgerStrategy();
            //result.ShowBurger();
            //burger.SetBurgerStrategy(new ExtraBeefBurgerStrategy());
            //result = burger.ExecuteBurgerStrategy();
            //result.ShowBurger();

            #endregion

            #region AbdoPattern
            BurgerPipline burgerPipline = new BurgerPipline();
            IBurgerService burgerService = new BurgerServices();
            burgerPipline.AddStep(burgerService.AddBuns)
                         .AddStep(burgerService.AddCheese)
                         .AddStep(burgerService.AddPatty)
                         .AddStep(burgerService.AddPickles)
                         .AddStep(burgerService.AddCheese);
            Burger burger = burgerPipline.Execute(new Burger());
            burger.ShowBurger();
            #endregion
        }
    }
}