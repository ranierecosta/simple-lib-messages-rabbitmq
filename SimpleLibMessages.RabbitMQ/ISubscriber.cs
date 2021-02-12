using System;
using System.Collections.Generic;

namespace SimpleLibMessages.RabbitMQ
{
    public interface ISubscriber : IDisposable
    {
        void Subscribe(Func<string, IDictionary<string, object>, bool> callback);
    }
}