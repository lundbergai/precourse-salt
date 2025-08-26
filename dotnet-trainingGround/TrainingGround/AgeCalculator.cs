namespace TrainingGround;

public class AgeCalculator
{
	public enum AgeCategory { Kid, Adult }

	public static int GetAge(int birthYear, int currentYear)
	{
		return currentYear - birthYear;
	}

	public static AgeCategory GetAgeCategory(Person person, int currentYear)
	{
		if (person.GetAge(currentYear) > 18)
		{
			return AgeCategory.Adult;
		}
		else
		{
			return AgeCategory.Kid;
		}
	}
}