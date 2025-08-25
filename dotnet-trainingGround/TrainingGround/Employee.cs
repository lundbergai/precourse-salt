namespace TrainingGround;

public class Employee : Person, IPrintable
{
	public string EmployeeId { get; set; }

	public Employee() { }

	public Employee(string name, string employeeId) : base(name)
	{
		EmployeeId = employeeId;
	}
	public string GetPrintString()
	{
		return @$"{Name} ({EmployeeId})
			{Address.Street} {Address.StreetNo}
			{Address.City}";
	}
}