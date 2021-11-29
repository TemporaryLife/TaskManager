using System;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Tasks("Помочь матери", "Срочно");
            var v = new Tasks("123", "123");
            var c = new Tasks("Помочь матери", "Срочно");
            Tasks.ShowActive();
            Tasks.CompleteTask(1);
            Tasks.CompleteTask(1);
            Console.WriteLine("-----------------------------");
            Tasks.ShowActive();
            Console.WriteLine("-----------------------------");
            Tasks.ShowDone();
        }
    }
}
