using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Data
{
    public interface ITodoData
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
    }
}