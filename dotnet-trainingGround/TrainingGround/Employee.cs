namespace TrainingGround;

public class Employee : Person, IPrintable
{
	public string EmployeeId { get; set; }
	public List<Address> Addresses { get; set; }

	public Employee()
	{
		this.Addresses = new List<Address>();
	}

	public Employee(string name, string employeeId) : base(name)
	{
		this.EmployeeId = employeeId;
		this.Addresses = new List<Address>();
	}
	public string GetPrintString()
	{
		return @$"{Name} ({EmployeeId})
			{Address.Street} {Address.StreetNo}
			{Address.City}";
	}
}