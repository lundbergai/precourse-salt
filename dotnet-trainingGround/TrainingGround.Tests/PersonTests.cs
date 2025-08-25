public class PersonTests
{
	[Fact]
	public void create_person_using_parameterless_constructor()
	{
		// arrange

		// act
		var p = new Person();

		// assert
		Assert.NotNull(p);
	}

	[Fact]
	public void create_person_using_constructor_with_name()
	{
		// arrange
		var name = "Marcus";

		// act
		var p = new Person(name);

		// assert
		Assert.NotNull(p);
		Assert.Equal(name, p.Name);
	}

	[Theory]
	[InlineData("Viktor", 1972, 50, 2022)]
	[InlineData("Marcus", 1982, 40, 2022)]
	[InlineData("Victor", 1992, 30, 2022)]
	[InlineData("Markus", 2022, 0, 2022)]
	public void a_person_born_x_is_y_in_z(string name, int birthYear, int expectedAge, int currentYear)
	{
		// arrange
		var p = new Person(name, birthYear);

		// act
		var age = p.GetAge(currentYear);

		// assert
		Assert.Equal(expectedAge, age);
	}
}