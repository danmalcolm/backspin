using Backspin.Core;
using NUnit.Framework;

namespace Tests.Core
{
    public class ClientTests
    {
		public class TestMessage
		{
			public string Message { get; set; }
		}

		[Test]
		public void Ctor()
		{
			var bus = new Client();
			bus.Send(new TestMessage { Message = "1" });
		}
    }
}
