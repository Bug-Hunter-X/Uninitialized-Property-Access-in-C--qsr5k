public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass()
    {
        // Initialize in the constructor
        MyProperty = 10; 
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // Now safe as MyProperty is guaranteed to have a value
    }
}