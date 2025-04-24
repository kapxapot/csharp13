namespace CSharp12;

public partial class Partial
{
    public partial string GetName();
    public partial string Name { get; set; }
}

// generated

public partial class Partial(string name)
{
    public partial string GetName()
    {
        return name;
    }

    //public partial string Name
    //{
    //    get => name;
    //    set => name = value;
    //}
}