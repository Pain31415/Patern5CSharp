using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class DispensingState : IState
    {
        public void InsertCoin(CoffeeMachine machine)
        {
            Console.WriteLine("Cannot insert coin now. Coffee is being dispensed.");
        }

        public void PressButton(CoffeeMachine machine)
        {
            Console.WriteLine("Cannot press button now. Coffee is being dispensed.");
        }

        public void DispenseCoffee(CoffeeMachine machine)
        {
            Console.WriteLine("Coffee is ready! Please take your coffee.");
            machine.currentState = new WaitingState();
        }
    }
}
