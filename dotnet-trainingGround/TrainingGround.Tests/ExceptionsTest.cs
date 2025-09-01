public class ExceptionTest
{
	[Fact]
	public void not_handling_an_exception()
	{
		// arrange
		var i = 1;

		// act
		var result = 14 / (i - 1);

		// assert
		Assert.Equal(14, result);
	}
}