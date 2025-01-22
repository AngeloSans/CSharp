using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly RedisService _redisService;

    public TodoController(RedisService redisService)
    {
        _redisService = redisService;
    }

    // Obter todos os Todos
    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
        var todos = await _redisService.GetAllTodosAsync();
        return Ok(todos);
    }

    // Adicionar um novo Todo
    [HttpPost]
    public async Task<IActionResult> AddTodo([FromBody] ToDo todo)
    {
        var todos = await _redisService.GetAllTodosAsync();
        todo.Id = todos.Count > 0 ? todos.Max(t => t.Id) + 1 : 1;  // Atribuindo um Id incremental
        await _redisService.SetTodoAsync(todo);
        return CreatedAtAction(nameof(GetTodos), new { id = todo.Id }, todo);
    }

    // Deletar um Todo
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(int id)
    {
        var todo = await _redisService.GetTodoAsync(id);
        if (todo == null)
        {
            return NotFound();
        }

        await _redisService.DeleteTodoAsync(id);
        return NoContent();
    }
}
