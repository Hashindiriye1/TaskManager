using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.CRUD
{
    public static class Delete
    {
        public static void Remove(List<Todo> todos)
        {
            Console.Write("Enter the number of the todo to delete: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index))
            {
                if (index <= 0 || index > todos.Count)
                {
                    Console.WriteLine("Invalid todo number. Please choose a valid number.");
                    return;
                }

                todos.RemoveAt(index - 1);
                Console.WriteLine("Todo deleted.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
