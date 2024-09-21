/*using RabbitMQ.Client;
using RabbitMQ.Client.Events;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "RabittMQ",
                     durable: false,
                     autoDelete: false,
                     arguments: null
    );

Console.WriteLine("Waiting for mensages");

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea)
*/