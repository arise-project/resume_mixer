using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace resume_mixer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(
            CancellationToken stoppingToken)
        {
            await Task.Run(
                () => {}, 
                stoppingToken);
        }
    }
}

