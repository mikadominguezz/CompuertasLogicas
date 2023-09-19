namespace Library;

public class Constant : IInput
{
    public bool Value { get; }

    public Constant(bool value)
    {
        this.Value = value;
    }
    public bool GetOutput()
    {
        return this.Value;
    }
}