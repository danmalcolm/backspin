using System;

namespace Backspin.Core.Server
{
	public class MessageSource : IObservable<Message>
	{
		public IDisposable Subscribe(IObserver<Message> observer)
		{
			throw new NotImplementedException();
		}
	}
}