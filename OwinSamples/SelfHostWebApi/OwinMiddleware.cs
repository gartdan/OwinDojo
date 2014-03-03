using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfHostWebApi
{
    public class LoggingMiddleware
    {
        Func<IDictionary<string, object>, Task> next;
        public LoggingMiddleware(Func<IDictionary<string, object>, Task> next)
        {
            this.next = next;
        }
        public async Task Invoke(IDictionary<string, object> environment)
        {
            Console.WriteLine("Logging Middleware Invoked");
            environment.Keys.ToList().ForEach(x => Console.WriteLine(string.Format("{0} = {1}", x, environment[x])));
            await next(environment);
        }
    }
}
