// Reference Types does not contain the actual data stored in a variable. 
// It only contains a reference to the variables.

class ReferenceType
{
    // Object types can be assigned values of any other types, e.g. value, reference, predefined, user-defined.

    /*
        Boxing and Unboxing

        Boxing: 
        - is used to store value types in the garbage-collected heap.
        - implicit conversion of value types into object type.
        - boxing a value type allocates an object instances on the heap and copies the value into new objects.

        int i = 0; value-type variable
        object o = i; boxing value-type 'i' -> object 'obj'
        object o = (object)i; explicit boxing

        stack      heap
        ==========|==========
        i (int)   |              // i - value type (int)
        123       |
        ----------|----------   
        o (object)| o* -> i      // object o points to i (boxed) in heap.
        {empty}   | i (boxed)    // the value of object o is pointing on the variable i.
                  | 123

        - if i is modified, the value of object o won't changed.  

        Unboxing:
        - explicit conversion from the type object to a value type.
        - Consist of: 
            checking the object instance to make sure that it is a boxed value of the given type.
            copying the value from the instances into the value-type variable.
        
        int i = 123;
        object o = i; // boxing i
        int j = (int)o; // unboxing o that has reference to i

        stack      heap
        ==========|==========
        o (object)| o* -> i      
        {empty}   | i (boxed)    
                  | 123
        ----------|----------
        j (int) 
        128
        j = (int)o

        item being unboxed must be a reference to an object that was previously created by boxing.

        Exceptions:
        NullReferenceException - if unboxing a null.
        InvalidCastException - if unboxing a reference to invalid value type.      
    */

    object objBoxed = 100; // Boxing
    int objUnboxed = (int)objBoxed; // Unboxing

    // Dynamic Type are similar to object type except that the type checking takes place at runtime.
    dynamic dBoxed = 100; // Boxing
    int dUnboxed = (int)dBoxed; // Unboxing

    // String Type allows string values to a variable.
    string unquotedStr = "Hello World";
    string quotedStr = @"Hello World";
    // More on Strings dir. 

    /*
        Other Reference Types
        - class, interface, delegates
    */
}