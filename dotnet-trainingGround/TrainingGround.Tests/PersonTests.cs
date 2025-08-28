namespace TrainingGround.Tests;

using TrainingGround;

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

	[Fact]
	public void an_employee_is_a_person()
	{
		// act
		var emp = new Employee();
		emp.LengthInMeters = 1.95;

		// assert
		Assert.IsType(typeof(Employee), emp);
		Assert.Equal(1.95, emp.LengthInMeters);
	}

	[Fact]
	public void an_employee_has_an_employeeId()
	{
		// act
		var emp = new Employee("Marcus", "234-BDAS");

		// assert
		Assert.IsType(typeof(Employee), emp);
		Assert.Equal("Marcus", emp.Name);
		Assert.Equal("234-BDAS", emp.EmployeeId);
	}

	[Fact]
	public void a_person_has_an_address()
	{
		// arrange
		var p = new Person("Marcus");

		// act
		p.Address = new Address();
		p.Address.Street = "A Street";
		p.Address.StreetNo = 23;
		p.Address.City = "Stockholm";

		// assert
		Assert.NotNull(p.Address);
		Assert.IsType(typeof(Address), p.Address);

		Assert.Equal("A Street", p.Address.Street);
		Assert.Equal(23, p.Address.StreetNo);
		Assert.Equal("Stockholm", p.Address.City);
	}

	[Fact]
	public void an_employee_gets_a_nice_printed_address()
	{
		// arrange
		var emp = new Employee("Marcus", "234-BDAS");
		emp.Address = new Address();
		emp.Address.Street = "A Street";
		emp.Address.StreetNo = 23;
		emp.Address.City = "Stockholm";

		// act
		var printString = emp.GetPrintString();

		// assert
		Assert.Equal(@"Marcus (234-BDAS)
			A Street 23
			Stockholm", printString);
	}

	public void Print(IPrintable printable)
	{
		var printString = printable.GetPrintString();
		Console.WriteLine(printString);
	}

	[Fact]
	public void can_print_printables()
	{
		// arrange
		var emp = new Employee("Ossian", "234-BDAS");
		emp.Address = new Address();
		emp.Address.Street = "B Street";
		emp.Address.StreetNo = 22;
		emp.Address.City = "Malmö";

		var p = new Person("Marcus");
		p.Address = new Address();
		p.Address.Street = "A Street";
		p.Address.StreetNo = 23;
		p.Address.City = "Stockholm";

		// act
		this.Print(p);
		this.Print(emp);
	}
}