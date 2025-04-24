namespace CSharp13;

public class FieldKeyword
{
    private string field;

    public FieldKeyword(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get => @field;
        set => @field = value;
    }
}
