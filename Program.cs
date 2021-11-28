using System;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Tasks("Помочь матери", "Срочно");
            var v = new Tasks("Помочь матери", "Срочно");
            var c = new Tasks("Помочь матери", "Срочно");
            Tasks.Show();
            Tasks.ChangeTask(10, "haha", "hahaahah");
            Tasks.Show();
        }
    }
}
