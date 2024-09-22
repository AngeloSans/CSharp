using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "RabbitMQ",
                     durable: false,
                     autoDelete: false,
                     arguments: null,
                     exclusive: false
    );

Console.WriteLine("Waiting for mensages");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>{
    var body = ea.Body.ToArray();
    var mensage = Encoding.UTF8.GetString(body);

    Console.WriteLine(" Receveid: " + mensage);
};
channel.BasicConsume(queue: "RabbitMQ",
                     autoAck: true,
                    consumer: consumer
);
Console.WriteLine("Click [enter] to get out");
Console.ReadLine();

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}