using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class BrewingState : IState
    {
        public void InsertCoin(CoffeeMachine machine)
        {
            Console.WriteLine("Coin already inserted. Brewing in progress...");
        }

        public void PressButton(CoffeeMachine machine)
        {
            Console.WriteLine("Button pressed. Brewing in progress...");
            machine.currentState = new DispensingState();
        }

        public void DispenseCoffee(CoffeeMachine machine)
        {
            Console.WriteLine("Cannot dispense coffee now. Brewing in progress...");
        }
    }
}
