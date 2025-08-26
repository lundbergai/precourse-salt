using static TrainingGround.AgeCalculator;

namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        // act
        var age = AgeCalculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);
    }

    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {
        // act
        var age = AgeCalculator.GetAge(2022, 2022);

        // assert
        Assert.Equal(0, age);
    }

    [Fact]
    public void return_under_18_for_kid()
    {
        // act
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);

        // assert
        Assert.Equal("Under 18 years", span);
    }
}