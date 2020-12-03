using System;
using Web.Client.Configurations;

namespace Web.Example.Configuration
{
    // Specify a class for each gateway that wants to OVERRIDE some default configurations
    public class EchoRetryRetryPolicyConfiguration : RetryPolicyDefaultConfiguration
    {
        public int RetriesCount { get; private set; }

        public override Action<Exception, TimeSpan> OnRetryCallback => (exception, span) =>
        {
            RetriesCount++;
            Console.WriteLine(span);
        };
    }
}