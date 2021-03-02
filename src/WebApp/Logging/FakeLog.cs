using System;

namespace WebApp.Logging
{
    public class FakeLog : ILog
    {
        private string _message = String.Empty;

        public void Append(string message) => _message += message;
        public string Get() => _message;
    }
}