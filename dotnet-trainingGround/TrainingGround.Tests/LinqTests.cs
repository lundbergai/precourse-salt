namespace TrainingGround.Tests;

public class LinqTests
{
	[Fact]
	public void loop_to_filter_numbers()
	{
		// arrange
		var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

		// act
		var filteredNumbers = new List<int>();

		foreach (var number in numbers)
		{
			if (number > 15)
			{
				filteredNumbers.Add(number);
			}
		}

		// assert
		var expectedNumbers = new List<int> { 53, 62, 17, 16 };
		Assert.Equal(expectedNumbers, filteredNumbers);
		Assert.Equal(4, filteredNumbers.Count);
	}

	[Fact]
	public void linq_to_filter_numbers()
	{
		// arrange
		var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

		// act
		var filteredNumbers = numbers.FindAll(n => n > 15);

		// assert
		var expectedNumbers = new List<int> { 53, 62, 17, 16 };
		Assert.Equal(expectedNumbers, filteredNumbers);
		Assert.Equal(4, filteredNumbers.Count);
	}

	[Fact]
	public void linq_to_find_first()
	{
		// arrange
		var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

		// act
		var filteredNumber = numbers.Find(n => n > 15);

		// assert
		var expectedNumber = 53;
		Assert.Equal(expectedNumber, filteredNumber);
	}

	[Fact]
	public void linq_to_check_if_any_matches()
	{
		// arrange
		var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

		// act
		var hasNumber = numbers.Any(n => n > 100);

		// assert
		Assert.False(hasNumber);
	}

	[Fact]
	public void linq_to_filter_people_by_age()
	{
		// arrange
		var people = new List<Person>{
			new Person("Aaaron"),
			new Person("Bea"),
			new Person("Ceasar"),
			new Person("Dave")
		};

		// act
		var filteredPersons = people.Where(p => p.Name.Length > 4).ToList();

		// assert
		Assert.Equal(2, filteredPersons.Count);
		Assert.Equal("Aaaron", filteredPersons[0].Name);
	}
}