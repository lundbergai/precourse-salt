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
}