public class Person
{
	public string? Name { get; private set; }
	public int BirthYear { get; set; }
	public double LengthInMeters { get; set; }

	public Person() { }
	public Person(string name)
	{
		this.Name = name;
	}

	public int GetAge(int currentYear)
	{
		return currentYear - this.BirthYear;
	}

}