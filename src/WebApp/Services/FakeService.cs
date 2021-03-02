using System;
using WebApp.Logging;

namespace WebApp.Services
{
    public class FakeService
    {
        public FakeService(IServiceProvider serviceProvider)
        {
            var log = (ILog)serviceProvider.GetService(typeof(ILog));
            log.Append($"{DateTime.UtcNow}\t{nameof(FakeService)}\r\n");
        }
    }
}