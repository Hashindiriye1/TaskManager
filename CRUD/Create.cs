using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.CRUD
{
    public static class Create
    {
        public static void Add(List<Todo> todos, List<string> history)
        {
            Console.Write("Enter the todo description: ");
            string description = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(description))
            {
                todos.Add(new Todo { Description = description, IsCompleted = false });
                history.Add(description); 
                Console.WriteLine("Todo added successfully.");
            }
            else
            {
                Console.WriteLine("Todo description cannot be empty.");
            }
        }
    }
}
