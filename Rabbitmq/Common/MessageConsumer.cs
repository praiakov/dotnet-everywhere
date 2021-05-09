using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Common
{
    public class MessageConsumer :
        IConsumer<Message>
    {
        readonly ILogger<MessageConsumer> _logger;

        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Message> context)
        {
            _logger.LogInformation($"Received Text: {context.Message.ServiceId} {context.Message.Id} {context.Message.Date} {context.Message.TextMessage}");

            return Task.CompletedTask;
        }
    }
}
