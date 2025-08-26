namespace TrainingGround;

public class AgeCalculator
{
	public enum AgeCategory { Kid }

	public static int GetAge(int birthYear, int currentYear)
	{
		return currentYear - birthYear;
	}

	public static AgeCategory GetAgeCategory(Person person, int currentYear)
	{
		return AgeCategory.Kid;
	}
}