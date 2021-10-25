using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TodosWebAPI.Models;

namespace TodoApp.Data
{
    public class TodosService : ITodosService
    {
        private string todoFile = "todos.json";
        private IList<Todo> todos;


        public TodosService()
        {
            if (!File.Exists(todoFile))
            {
                
                Seed();
                string todosAsJson = JsonSerializer.Serialize(todos);
                File.WriteAllText(todoFile, todosAsJson);
            }
            else
            {
                string content = File.ReadAllText(todoFile);
                todos = JsonSerializer.Deserialize<List<Todo>>(content);
            }
        }


        public IList<Todo> GetTodos()
        {
            
            return new List<Todo>(todos);
        }

        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
            string todoAsJson = JsonSerializer.Serialize(todo);
            File.WriteAllText(todoFile,todoAsJson);
        }

        public void DeleteTodo(int todoId)
        {
            todos.Remove(todos.First(todo => todo.TodoId == todoId));
        }

        private void Seed()
        {
            Todo[] ts =
            {
                new Todo {UserId = 1, TodoId = 1, Title = "Do dishes", IsCompleted = false},
                new Todo {UserId = 1, TodoId = 2, Title = "Walk the dog", IsCompleted = false},
                new Todo {UserId = 2, TodoId = 3, Title = "Do DNP homework", IsCompleted = true},
                new Todo {UserId = 3, TodoId = 4, Title = "Eat breakfast", IsCompleted = false},
                new Todo {UserId = 4, TodoId = 5, Title = "Mow lawn", IsCompleted = true},
            };
            todos = ts.ToList();
        }
    }
}