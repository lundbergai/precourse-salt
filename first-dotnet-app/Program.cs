Console.Write("What is your name? ");
var name = Console.ReadLine()!;

var greeting = Greet(name);

Console.WriteLine(greeting);

static string Greet(string namePassedIn)
{
  return $"Welcome to SALT, {namePassedIn}";
}
