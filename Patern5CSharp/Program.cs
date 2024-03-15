namespace Patern5CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            coffeeMachine.DispenseCoffee();

            coffeeMachine.InsertCoin();

            coffeeMachine.DispenseCoffee();

            coffeeMachine.PressButton();

            coffeeMachine.DispenseCoffee();

            coffeeMachine.DispenseCoffee();
        }
    }
}
