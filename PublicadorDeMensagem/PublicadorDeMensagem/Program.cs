using RabbitMQ.Client;
using System.Text;

namespace PublicadorDeMensagem;

public class Program
{

    static void Main(string[] args)
    {
        Console.Write("Digite a mensagem que deseja enviar para a fila: ");
        var mensagemParaEnviar = Console.ReadLine();
        PublicarMensagemNoRabbit(mensagemParaEnviar);
    }

    public static void PublicarMensagemNoRabbit(string mensagemParaEnviar)
    {
        var factory = new ConnectionFactory { HostName = "localhost" };

        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare(queue: "queue1",
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);


        string mensagem = mensagemParaEnviar;
        var body = Encoding.UTF8.GetBytes(mensagem);

        channel.BasicPublish(exchange: string.Empty, routingKey: "queue1", basicProperties: null, body: body);

        Console.WriteLine($"[X] Enviado {mensagem}");
    }
}
