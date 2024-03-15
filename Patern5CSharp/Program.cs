namespace Patern5CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.SetState("State #1");
            caretaker.SetMemento(originator.SaveStateToMemento());

            originator.SetState("State #2");
            caretaker.SetMemento(originator.SaveStateToMemento());

            originator.RestoreStateFromMemento(caretaker.GetMemento());
        }
    }
}
