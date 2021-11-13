using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ShedulerDay.Settings;

namespace ShedulerDay
{
    public class CoreService
    {
        private ILogger<CoreService> _logger;
        private readonly TelegramSettings _settings;

        public CoreService(ILogger<CoreService> logger, IOptionsMonitor<TelegramSettings> settings)
        {
            _settings = settings.CurrentValue;
            _logger = logger;
        }

        public Task Start()
        {
            Console.Write(_settings.Connection);
            return Task.CompletedTask;
        }
    }
}