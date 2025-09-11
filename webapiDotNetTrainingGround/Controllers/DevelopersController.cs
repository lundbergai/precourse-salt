using webapiDotNetTrainingGround.Models;
using Microsoft.AspNetCore.Mvc;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevelopersController : ControllerBase
{
	private static int _nextId = 3;
	private static List<Developer> _db = new List<Developer>() {
			new Developer() { Id = 1, Name = "Marcus", Email = "marcus@salt.dev" },
			new Developer() { Id = 2, Name = "Beatrice", Email = "bea@salt.dev" },
		};

	[HttpGet]
	public List<Developer> GetDevelopers()
	{
		return _db.Select(d => new Developer
		{
			Id = d.Id,
			Name = d.Name,
			Email = d.Email
		}).ToList();
	}

	[HttpGet("{id}")]
	public Developer? GetDeveloperById(int id)
	{
		return _db.Where(d => d.Id == id).Select(d => new Developer
		{
			Id = d.Id,
			Name = d.Name,
			Email = d.Email
		}).FirstOrDefault();
	}

	[HttpPost]
	public IActionResult CreateDeveloper(Developer newDev)
	{
		newDev.Id = _nextId++;
		_db.Add(newDev);

		return CreatedAtAction(nameof(GetDeveloperById), new { id = newDev.Id }, newDev);
	}
}