using TrainingGround;

public class Person
{
	public string? Name { get; private set; }
	public int BirthYear { get; private set; }
	public double LengthInMeters { get; set; }
	public Address Address { get; set; }

	public Person() { }

	public Person(string name)
	{
		this.Name = name;
	}

	public Person(string name, int birthYear)
	{
		this.Name = name;
		this.BirthYear = birthYear;
	}

	public int GetAge(int currentYear)
	{
		return currentYear - this.BirthYear;
	}

}