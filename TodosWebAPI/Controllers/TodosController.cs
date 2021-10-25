using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodosWebAPI.Models;


namespace TodosWebAPI.Controllers

{
    [ApiController]
    [Route("[controller]/bøgse")]
    public class TodosController : ControllerBase
    {
        private ITodosService _todosService;
        private IList<Todo> todos;

        public TodosController(ITodosService todosService)
        {
            _todosService = todosService;
        }


        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? isCompleted, [FromQuery] int? userId)
        {
            try
            {
                todos = _todosService.GetTodos();

                IList<Todo> todosToShow = ExecuteFilter(isCompleted, userId);

                return Ok(todosToShow);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<Todo>> AddTodo([FromBody] Todo todo)
        {
            try
            {
                _todosService.AddTodo(todo);
                return Created($"/{todo.TodoId}", todo);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTodo([FromQuery] int todoId)
        {
            try
            {
                _todosService.DeleteTodo(todoId);
                return Accepted($"YOU deleted it {todoId}");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


        [HttpPatch]
        public async Task<ActionResult> PatchTodo([FromBody] Todo todo)
        {
            try
            {
                _todosService.UpdateTodo(todo);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return StatusCode(404, e.Message);
            }
        }


        private IList<Todo> ExecuteFilter(bool? filterByIsCompleted, int? filterById)
        {
            return todos.Where(t =>
                (filterById != null && t.UserId == filterById || filterById == null) &&
                (filterByIsCompleted != null
                 && t.IsCompleted == filterByIsCompleted
                 || filterByIsCompleted == null)).ToList();
        }
    }
}