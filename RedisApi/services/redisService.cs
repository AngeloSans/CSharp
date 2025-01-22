using StackExchange.Redis;
using System.Text.Json;

public class RedisService
{
    private readonly ConnectionMultiplexer _redis;
    private readonly IDatabase _database;

    public RedisService(string connectionString)
    {
        _redis = ConnectionMultiplexer.Connect(connectionString);
        _database = _redis.GetDatabase();
    }

    // Armazenar um Todo no Redis (em cache)
    public async Task SetTodoAsync(ToDo todo)
    {
        var json = JsonSerializer.Serialize(todo);
        await _database.StringSetAsync($"todo:{todo.Id}", json);
    }

    // Obter um Todo do Redis (em cache)
    public async Task<ToDo?> GetTodoAsync(int id)
    {
        var json = await _database.StringGetAsync($"todo:{id}");
        return json.IsNullOrEmpty ? null : JsonSerializer.Deserialize<ToDo>(json);
    }

    // Obter todos os Todos do Redis
    public async Task<List<ToDo>> GetAllTodosAsync()
{
    var todos = new List<ToDo>();
    // Usa 'await foreach' para iterar sobre o IAsyncEnumerable<RedisKey>
    await foreach (var key in _database.Multiplexer.GetServer("localhost", 6379).KeysAsync(pattern: "todo:*"))
    {
        var json = await _database.StringGetAsync(key);
        if (!json.IsNullOrEmpty)
        {
            todos.Add(JsonSerializer.Deserialize<ToDo>(json));
        }
    }
    return todos;
}


    // Deletar um Todo do Redis
    public async Task DeleteTodoAsync(int id)
    {
        await _database.KeyDeleteAsync($"todo:{id}");
    }
}
