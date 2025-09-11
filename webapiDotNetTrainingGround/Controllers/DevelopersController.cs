using webapiDotNetTrainingGround.Models;
using Microsoft.AspNetCore.Mvc;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DevelopersController : ControllerBase
{
	private readonly List<Developer> _db;

	public DevelopersController()
	{
		_db = new();
	}

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
}