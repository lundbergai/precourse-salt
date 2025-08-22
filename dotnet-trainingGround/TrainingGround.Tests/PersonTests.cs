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
}