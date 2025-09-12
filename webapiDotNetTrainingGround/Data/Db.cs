using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Data;

public class Db
{
	public List<Developer> Developers { get; set; }

	public Db()
	{
		Developers = new List<Developer>() {
			new Developer() { Id = 1, Name = "Marcus", Email = "marcus@salt.dev" },
			new Developer() { Id = 2, Name = "Beatrice", Email = "bea@salt.dev" },
		};
	}
}