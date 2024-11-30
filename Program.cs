using TaskManager.CRUD;
using TaskManager.Models;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>();
            List<string> history = new List<string>();   
            string input;

            Console.WriteLine("Todo List App");
            Console.WriteLine("-------------------");

            do
            {
                Console.WriteLine("\n1. Add Todo\n2. Show Todos\n3. Update todos\n4. Delete Todo\n5. View Todo History\n6. Exit");
                Console.Write("Choose an option: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Create.Add(todos, history);
                        break;
                    case "2":
                        Read.Show(todos);
                        break;
                    case "3":
                        Update.ToggleCompletion(todos);
                        break;
                    case "4":
                        Delete.Remove(todos);
                        break;
                    case "5":
                        Read.ViewHistory(history);
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            } while (input != "6");
        }
    }
}