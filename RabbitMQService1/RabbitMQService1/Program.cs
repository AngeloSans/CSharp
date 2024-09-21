


using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

var factory = new ConnectionFactory { HostName = "localhost"};
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "RabittMQ",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null
    );
Console.WriteLine("Type your mensage and smash <ENTER>");

while (true)
{
    string mensage = Console.ReadLine();
    if (mensage == "")
        break;
    var Student = new Student { Id = 1, Name = "Angelo" };
    mensage = JsonSerializer.Serialize(Student);

    var body = Encoding.UTF8.GetBytes(mensage);

    channel.BasicPublish(exchange: string.Empty,
                         routingKey: "RabittMQ",
                         basicProperties: null,
                         body: body);
    Console.WriteLine($" [x] Seding {mensage}");
       
   
}


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}