using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Tasks
    {

        private static List<Tasks> tasks = new List<Tasks>();


        private int ID;
        private string TaskName { get; set; }
        private string TaskDescription { get; set; }
        private DateTime Deadline { get; set; }


        public Tasks(string taskName, string taskDescription)
        {
            
            this.ID = tasks.Count;
            this.TaskName = taskName;
            this.TaskDescription = taskDescription;

            tasks.Add(this);
        }

        public static void Show()
        {
            for (int i=0; i<tasks.Count; i++)
            {
                Console.WriteLine($"{tasks[i].ID} {tasks[i].TaskName}: {tasks[i].TaskDescription}");
            }
        }

        public static void DeleteTask(int id)
        {
            if (id<tasks.Count)
            {
                tasks.RemoveAt(id);
                for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].ID = i;
                }
            }
            
            else
            {
                //TODO: Окно о несуществующей задаче
            }
        }

        public static void ChangeTask(int id, string newName, string newDescription)
        {
            if (id<tasks.Count)
            {
                tasks[id].TaskName = newName;
                tasks[id].TaskDescription = newDescription;
            }
            else
            {
                //TODO: Окно о несуществующей задаче
            }
        }

        
    }
}
