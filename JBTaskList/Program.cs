using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBTaskList
{
    class Program
    {
        /* https://www.c-sharpcorner.com/article/c-sharp-list/, and 
           https://forgetcode.com/csharp/2158-create-a-list-dynamically-from-user-input used
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insert task");
            String input = Console.ReadLine();
            List<string> TaskList = new List<string>();
            TaskList.Add(input);
            String inputNewTask = Console.ReadLine();
            TaskList.Add(inputNewTask);
            foreach (var task in TaskList) 
            {
                Console.WriteLine(task);
            }
        }
     
       

        
            
    } 
}       

        
           /* {
                List<string> MyTasks = new List<string>();
                string[] tasks = { "laundry", "garbage disposal", "homework", "store" };
                List<string> tasksList = new List<string>(tasks);
            } */