namespace TrainingGround;

public class Employee : Person
{
	public string EmployeeId { get; set; }

	public Employee() { }

	public Employee(string name, string employeeId) : base(name)
	{
		EmployeeId = employeeId;
	}
}