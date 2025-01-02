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

## Layout Conventions

Good layout uses formatting to emphasize the structure of your code and to make the code easier to read.

- Use the default code editor settings.

- Write only one statement per line.

- Write only one declaration per line.

- If continuation lines are not indented automatically, indent them one tab stop (four spaces).

- Add at least one blank line between method definitions and property definitions.

- Use parenthesis to make clauses in an expression apparent, as shown in the following code.

---

## Commenting Convention

- Place the comment on a seperate line, not at the end of line.

- Being comment text with uppercase letter.

- End comment with a period.

- Insert one space between comment delimiter and the comment text.

- Don't create formatted blocks of asterisk around comments.

- Ensure all public members have necessary XML components providing appropriate description about their behavior.

---
