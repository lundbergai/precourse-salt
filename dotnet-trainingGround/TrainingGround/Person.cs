public class Person
{
	public string? Name { get; private set; }
	public int? BirthYear { get; private set; }
	public double? LengthInMeters { get; private set; }

	public Person() { }
	public Person(string name)
	{
		this.Name = name;
	}
}