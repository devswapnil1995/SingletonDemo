// See https://aka.ms/new-console-template for more information
using SingletonDemo;

Console.WriteLine("Singleton with Lock Example in .NET Core");

Parallel.For(0, 5, i => { 
    var logger = Logger.Instance;
    logger.Log($"Log entry from Task {i}");
});

var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

Console.WriteLine($"logger1 and logger2 are same instance: {ReferenceEquals(logger1, logger2)}");
