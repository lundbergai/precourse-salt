public class ExceptionTest
{
	[Fact]
	public void not_handling_an_exception()
	{
		try
		{
			// arrange
			var i = 1;

			// act
			var result = 14 / (i - 1);
		}
		catch (System.DivideByZeroException ex)
		{
			// assert 
			Assert.IsType<System.DivideByZeroException>(ex);
		}
	}
}