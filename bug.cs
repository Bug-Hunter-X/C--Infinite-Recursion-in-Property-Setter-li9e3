public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void IncrementValue()
    {
        //Bug: Using Value property instead of _value field
        Value++; //This will cause infinite recursion
    }
}