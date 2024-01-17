namespace Core_Console;

// Command (write to db) model for DBModel
public class DbCommand : IMinimalModel
{
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public int Id { get; set; }
    public bool ValidateId()
    {
		return new ExtendedModel().ValidateId();
		//return new A().ValidateId();
		// return new Validation().ValidateId(this);
	}
}