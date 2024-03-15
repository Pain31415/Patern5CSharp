using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class WaitingState : IState
    {
        public void InsertCoin(CoffeeMachine machine)
        {
            Console.WriteLine("Coin inserted.");
            machine.currentState = new BrewingState();
        }

        public void PressButton(CoffeeMachine machine)
        {
            Console.WriteLine("No coin inserted. Please insert a coin first.");
        }

        public void DispenseCoffee(CoffeeMachine machine)
        {
            Console.WriteLine("No coffee to dispense. Please insert a coin and press the button.");
        }
    }
}
