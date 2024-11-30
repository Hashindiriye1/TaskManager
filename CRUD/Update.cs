using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.CRUD
{
    public static class Update
    {
        public static void ToggleCompletion(List<Todo> todos)
        {
            Console.Write("Enter the number of the todo to toggle completion: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index))
            {
                if (index <= 0 || index > todos.Count)
                {
                    Console.WriteLine("Invalid todo number. Please choose a valid number.");
                    return;
                }

                // Toggle the IsCompleted property
                todos[index - 1].IsCompleted = !todos[index - 1].IsCompleted;
                string status = todos[index - 1].IsCompleted ? "completed" : "incomplete";
                Console.WriteLine($"Todo marked as {status}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

}
