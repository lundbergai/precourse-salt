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
	public List<DeveloperResponseDto> GetDevelopers()
	{
		return _db.Developers.Select(d => new DeveloperResponseDto
		{
			Id = d.Id,
			Name = d.Name,
			Email = d.Email
		}).ToList();
	}

	[HttpGet("{id}")]
	public DeveloperResponseDto? GetDeveloperById(int id)
	{
		return _db.Developers.Where(d => d.Id == id).Select(d => new DeveloperResponseDto
		{
			Id = d.Id,
			Name = d.Name,
			Email = d.Email
		}).FirstOrDefault();
	}

	[HttpPost]
	public IActionResult CreateDeveloper(DeveloperCreateDto dto)
	{
		var newDeveloper = new Developer()
		{
			Id = _nextId++,
			Name = dto.Name,
			Email = dto.Email,
		};

		_db.Developers.Add(newDeveloper);

		var responseDto = new DeveloperResponseDto()
		{
			Id = newDeveloper.Id,
			Name = newDeveloper.Name,
			Email = newDeveloper.Email
		};

		return CreatedAtAction(nameof(GetDeveloperById), new { id = responseDto.Id }, responseDto);
	}
}