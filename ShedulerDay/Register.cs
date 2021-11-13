using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ShedulerDay.Settings;

namespace ShedulerDay
{
    public class Register
    {
        public static IServiceCollection Add(IConfiguration _configuration)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<CoreService>();
            collection.AddOptions();
            collection.Configure<TelegramSettings>(_configuration.GetSection(nameof(TelegramSettings)));
            return collection;
        }
    }
}