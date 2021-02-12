using RabbitMQ.Client;
using System;

namespace SimpleLibMessages.RabbitMQ
{
    public interface IConnectionProvider : IDisposable
    {
        IConnection GetConnection();
    }
}