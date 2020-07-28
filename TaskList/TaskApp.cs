using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class TaskApp
    {
        public void Run()
        {
            List<string> taskList = ReadListFromFile();
            PrintTaskList(taskList);
        }

        private void PrintTaskList(List<string> taskList)
        {
            foreach (var t in taskList)
            {
                Console.WriteLine(t);
            }
        }
        //testing git hub commands
        private List<string> ReadListFromFile()
        {
            var taskList = new List<string>();

            try
            {

                using (StreamReader sr = new StreamReader(@"C:\Users\J\Desktop\Retirement Prep 2020\Skillbridge\MSSA\in class project\ToDoList.txt"))
                {
                    var input = sr.ReadLine();
                    taskList.Add(input);
                }
            }
            catch (FileNotFoundException)
            { ; }

            return taskList;
        }
    }
}
