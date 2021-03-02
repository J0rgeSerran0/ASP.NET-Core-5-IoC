using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using WebApp.Logging;
using WebApp.Services;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FooController : Controller
    {
        private readonly ILog _log;

        public FooController(ILog log, IServiceProvider serviceProvider)
        {
            var fakeService = new FakeService(serviceProvider);

            Thread.Sleep(2500);

            _log = log;
            _log.Append($"{DateTime.UtcNow}\t{nameof(FooController)}\r\n");
        }

        [HttpGet(nameof(Index))]
        public IActionResult Index() =>
            Ok(_log.Get());
    }
}