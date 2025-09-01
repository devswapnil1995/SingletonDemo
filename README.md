# SingletonDemo
The Singleton Design Pattern is one of the most widely used creational design patterns in .NET. Let’s build a small .NET Core console project that demonstrates it with optimized implementation (thread-safe, lazy initialization).

# Steps

1. Create sealed class to avoid inheritance
2. Create lock to handle instance initialization check in case of multi-threading
3. Create private constructor in order to restrict instance creation
4. Create instance getter property with all checks
   -->First check (no lock) - better performance
   -->Thread-safe block 
   -->Second check (inside lock) - ensures only one instance

# Key Points
Double-Checked Locking → avoids unnecessary locking after instance is created.

Thread-Safe → ensures only one instance is created, even with multiple threads.

Optimized → lock is only acquired during the first creation.