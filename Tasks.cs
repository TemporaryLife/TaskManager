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
        private static List<Tasks> doneTasks=new List<Tasks>();

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

        public static void ShowActive()
        {
            if (tasks.Count != 0)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{tasks[i].ID} {tasks[i].TaskName}: {tasks[i].TaskDescription}");
                }
            }
            else
            {
                //TODO : Коллекция пуста
            }

        }

        public static void ShowDone()
        {
            if (doneTasks.Count != 0)
            {
                for (int i = 0; i < doneTasks.Count; i++)
                {
                    Console.WriteLine($"{doneTasks[i].ID} {doneTasks[i].TaskName}: {doneTasks[i].TaskDescription}");
                }
            }
            else
            {
                //TODO: Выполненных задач нет
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

        public static void CompleteTask(int id)
        {
            if (id < tasks.Count)
            {
                doneTasks.Add(tasks[id]);
                DeleteTask(id);
                for (int i = 0; i < doneTasks.Count; i++)
                {
                    doneTasks[i].ID = i;
                }
                
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
