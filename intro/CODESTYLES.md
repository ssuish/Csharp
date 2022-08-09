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
