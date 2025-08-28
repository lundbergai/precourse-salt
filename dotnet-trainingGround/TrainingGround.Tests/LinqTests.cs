public class LinqTests
{
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
}