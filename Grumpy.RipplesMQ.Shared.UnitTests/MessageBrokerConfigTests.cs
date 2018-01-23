using FluentAssertions;
using Grumpy.RipplesMQ.Shared.Config;
using Xunit;

namespace Grumpy.RipplesMQ.Shared.UnitTests
{
    public class MessageBrokerConfigTests
    {
        [Fact]
        public void LocaleQueueShouldBeCorrect()
        {
            MessageBrokerConfig.LocaleQueueName.Should().Be("RipplesMQ.MessageBroker.Locale");
        }
    }
}
