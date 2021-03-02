using System;
using System.Diagnostics;

namespace WebApp.Logging
{
    public class FakeLog : ILog, IDisposable
    {
        private string _message = String.Empty;

        public void Append(string message) => _message += message;

        public void Dispose()
        {
            Debug.Print($"{nameof(FakeLog)}.{nameof(Dispose)}");
        }

        public string Get() => _message;
    }
}