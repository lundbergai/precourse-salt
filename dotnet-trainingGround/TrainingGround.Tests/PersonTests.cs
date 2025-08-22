public class PersonTests
{
	[Fact]
	public void create_person_using_parameterless_constructor()
	{
		// arrange
		var p = new Person();

		// act

		// assert
		Assert.NotNull(p);
	}
}