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
        //Solution: Directly modify the backing field
        _value++;
    }
}