using TrainingGround;
using static TrainingGround.AgeCalculator;

public class ConditionalTests
{
	[Fact]
	public void should_be_kid_when_younger_than_18()
	{
		// arrange
		var p = new Person("Viktor", 2005);

		// act
		var category = AgeCalculator.GetAgeCategory(p, 2022);

		// assert
		Assert.Equal(AgeCategory.Kid, category);
	}

	[Fact]
	public void should_be_adult_when_older_than_18()
	{
		// arrange
		var p = new Person("Viktor", 2002);

		// act
		var category = AgeCalculator.GetAgeCategory(p, 2022);

		// assert
		Assert.Equal(AgeCategory.Adult, category);
	}

	[Fact]
	public void when_50_then_prime_Age()
	{
		// arrange
		var p = new Person("Viktor", 1972);

		// act
		var category = AgeCalculator.GetAgeCategory(p, 2022);

		// assert
		Assert.Equal(AgeCategory.Prime, category);
	}
}