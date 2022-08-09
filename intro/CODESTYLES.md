# C\# Coding Standards and Best Practices  

## Pascal Casing  

- Class, method, record, structs name use pascal casing.

```cs
public record PhysicalAddress(
    string Street,
    string City,
    string StateOrProvince,
    string ZipCode);
```

- Interface, use pascal casing in addition to prefixing the name with 'I'.

```cs
public interface IWorkerQueue
{
}
```

- Naming public members such as fields, properties, events, methods, and local functions should be pascal casing.

```cs
public class ExampleEvents
{
    // A public field, these should be used sparingly
    public bool IsValid;

    // An init-only property
    public IWorkerQueue WorkerQueue { get; init; }

    // An event
    public event Action EventProcessing;

    // Method
    public void StartEventProcessing()
    {
        // Local function
        static int CountQueueItems() => WorkerQueue.Count;
        // ...
    }
}
```

---

## Camel Casing  

- Use camel casing when naming private or internal fields, and prefix them with _ .

```cs
public class DataService
{
    private IWorkerQueue _workerQueue;
}
```

- Static fields that are private or internal, use 's_' prefix and for thread static use 't_' .

```cs
public class DataService
{
    private static IWorkerQueue s_workerQueue;

    [ThreadStatic]
    private static TimeSpan t_timeSpan;
}
```

- When writing method parameters, use camel casing.

``` cs
public T SomeMethod<T>(int someNumber, bool isValid)
{
}
```

---

