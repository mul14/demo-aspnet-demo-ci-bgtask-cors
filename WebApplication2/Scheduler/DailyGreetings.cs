using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication2.Scheduler
{
    public class DailyGreetings : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Start background task daily greetings");

            Timer timer = new Timer(Greetings, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stop background process");

            return Task.CompletedTask;
        }

        public void Greetings(object state)
        {
            var content = new List<string>()
            {
                DateTime.Now.ToString(),
                "Hello"
            };

            System.IO.File.AppendAllLinesAsync("Greetings.txt", content);
        }
    }
}
