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
}