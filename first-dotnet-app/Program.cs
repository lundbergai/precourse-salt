Console.Write("What is your name? ");
var name = Console.ReadLine()!;
Console.Write("When does that course start? ");
var startDate = Console.ReadLine()!;

var greeting = Greet(name, startDate);

Console.WriteLine(greeting);

static string Greet(string namePassedIn, string startDate)
{
  try
  {
    var startDateParsed = DateTime.Parse(startDate);
    var today = DateTime.Now;
    var daysUntilStart = (startDateParsed - today).Days;

    return $"Welcome to SALT, {namePassedIn}. \nToday it is {daysUntilStart} days left until the course starts";
  }
  catch (Exception e)
  {
    return $"Error: {e.Message}";
  }
}