using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern5CSharp
{
    public class Caretaker
    {
        private Memento memento;

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Caretaker: Saving Memento");
            this.memento = memento;
        }

        public Memento GetMemento()
        {
            Console.WriteLine("Caretaker: Restoring Memento");
            return memento;
        }
    }
}
