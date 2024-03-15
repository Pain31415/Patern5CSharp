using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public interface IState
    {
        void InsertCoin(CoffeeMachine machine);
        void PressButton(CoffeeMachine machine);
        void DispenseCoffee(CoffeeMachine machine);
    }
}
