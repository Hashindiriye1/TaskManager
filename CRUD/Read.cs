using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.CRUD
{
    public static class Read
    {
        public static void Show(List<Todo> todos)
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No todos found.");
                return;
            }

            Console.WriteLine("\nYour Todos:");
            for (int i = 0; i < todos.Count; i++)
            {
                string checkbox = todos[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {checkbox} {todos[i].Description}");
            }
        }

        public static void ViewHistory(List<string> history)
        {
            if (history.Count == 0)
            {
                Console.WriteLine("No todos have been created.");
                return;
            }

            Console.WriteLine("\nTodo History (All Created Todos):");
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {history[i]}");
            }
        }
    }

}
