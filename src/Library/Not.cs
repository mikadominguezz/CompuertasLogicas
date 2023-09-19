using System.Collections.Generic;

namespace Library;

public class Not : IInput
{
    public string Name { get; set; }
    public Not(string name)
    {
        this.Name = name;
    }
    public IInput input { get; set; }
    public bool GetOutput()
    {
        return !input.GetOutput();
    }
}