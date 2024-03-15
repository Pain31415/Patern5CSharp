using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class Originator
    {
        private string state;

        public void SetState(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }

        public Memento SaveStateToMemento()
        {
            Console.WriteLine("Originator: Saving state to Memento");
            return new Memento(state);
        }

        public void RestoreStateFromMemento(Memento memento)
        {
            state = memento.GetSavedState();
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
        }
    }
}
