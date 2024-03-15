using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class CoffeeMachine
    {
        public IState currentState { get; set; }

        public CoffeeMachine()
        {
            currentState = new WaitingState();
        }

        public void InsertCoin()
        {
            currentState.InsertCoin(this);
        }

        public void PressButton()
        {
            currentState.PressButton(this);
        }

        public void DispenseCoffee()
        {
            currentState.DispenseCoffee(this);
        }
    }
}
