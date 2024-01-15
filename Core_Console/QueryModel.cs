using JetBrains.Annotations;

namespace Core_Console;

[Query]
// Query (read from db) model for DBModel
public class ExtendedModel : IMinimalModel
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Id { get; set; }

    public bool ValidateId()
    {
		return new Validation2().ValidateId(this);
        //return new Validation().ValidateId(this);
    }
}

[Query]
// Query (read from db) model for DBModel
public class ExtendedModel2 : IMinimalModel
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Id { get; set; }

    public bool ValidateId()
    {
        return new Validation().ValidateId(this);
        //return new Validation().ValidateId(this);
    }
}


public class A: IMinimalModel
{
    public int Id
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool ValidateId()
    {
        return new Validation2().ValidateId(this);
        //return new Validation().ValidateId(this);
    }
}
