using System.Collections.Generic;
namespace Library;

public class Or : IInput
{
    public string Name { get;  set; }
    List<IInput> inputs = new List<IInput>();
    public void Add (IInput input)
    {
        inputs.Add (input);
    }
    public bool GetOutput()
    {
        foreach (IInput input in inputs)
        {
            if (input.GetOutput())
            { 
                return true;
            }
        }
        return false;
    }
}