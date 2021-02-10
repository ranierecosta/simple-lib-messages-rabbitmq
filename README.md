# SimpleLibMessages Rabbitmq

SimpleLibMessages Rabbitmq is a simple wrapper around RabbitMQ.Client encapsulating the boilerplate code.

## Installation

Use the Nuget package manager [Nuget](https://www.nuget.org/packages/SimpleLibMessages.RabbitMQ/) to install SimpleLibMessages.RabbitMQ

```bash
Install-Package SimpleLibMessages.RabbitMQ -Version 0.0.0.1
```

## Usage

DI Registration

```csharp
services.AddSingleton<IConnectionProvider>(new ConnectionProvider("Queue Url"));
services.AddSingleton<ISubscriber>(x => new Subscriber(x.GetService<IConnectionProvider>(),
	"exchange name",
    "queue name",
    "routing key",
    ExchangeType.Topic));
services.AddScoped<IPublisher>(x => new Publisher(x.GetService<IConnectionProvider>(),
	"exchange name",
    ExchangeType.Topic));
```

Publisher

```csharp
publisher.Publish(JsonConvert.SerializeObject(object), "routing key", headers);
```

Subscriber
```csharp
subscriber.Subscribe((message, header) => {
	Console.WriteLine(message);
    return true;
});
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)