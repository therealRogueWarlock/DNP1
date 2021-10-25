using System.Collections.Generic;
using TodosWebAPI.Models;

namespace TodoApp.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);

        void DeleteTodo(int todoId);

        void UpdateTodo(Todo todo);
        

    }
}