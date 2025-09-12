using webapiDotNetTrainingGround.Models;
using webapiDotNetTrainingGround.Data;
using Microsoft.AspNetCore.Mvc;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevelopersController : ControllerBase
{
	private static int _nextId = 3;
	private Db _db;

	public DevelopersController(Db db)
	{
		_db = db;
	}

	[HttpGet]
	public List<Developer> GetDevelopers()
	{
		return _db.Developers.Select(d => new Developer
		{
			Id = d.Id,
			Name = d.Name,
			Email = d.Email
		}).ToList();
	}

	[HttpGet("{id}")]
	public Developer? GetDeveloperById(int id)
	{
		return _db.Developers.Where(d => d.Id == id).Select(d => new Developer
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
		_db.Developers.Add(newDev);

		return CreatedAtAction(nameof(GetDeveloperById), new { id = newDev.Id }, newDev);
	}
}