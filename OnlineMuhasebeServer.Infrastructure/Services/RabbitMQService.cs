using Newtonsoft.Json;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Domain.Dtos;
using RabbitMQ.Client;
using System.Text;

namespace OnlineMuhasebeServer.Infrastructure.Services;

public sealed class RabbitMQService : IRabbitMQService
{
    public void SendQueue(ReportDto reportDto)
    {
        var factory = new ConnectionFactory();
        factory.Uri = new Uri("amqps://fxckiipg:dfpYbUG8zitftEciB_KC8WSQy3GtmOhX@chimpanzee.rmq.cloudamqp.com/fxckiipg");

        using var connection = factory.CreateConnection();

        var channel = connection.CreateModel();
        channel.QueueDeclare("Reports", true, false, false);
        var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(reportDto));
        channel.BasicPublish(String.Empty, "Reports", null, body);


    }
}
