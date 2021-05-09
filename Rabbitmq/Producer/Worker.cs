using Common;
using MassTransit;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Producer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IBus _bus;
        
        public Worker(ILogger<Worker> logger, IBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _bus.Publish(new Message
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    TextMessage = "Hello world",
                    ServiceId = Guid.NewGuid()
                });

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
