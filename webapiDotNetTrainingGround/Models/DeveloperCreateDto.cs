using System.ComponentModel.DataAnnotations;

namespace webapiDotNetTrainingGround.Models;

public class DeveloperCreateDto
{
	[Required]
	public string? Name { get; set; }
	[Required]
	public string? Email { get; set; }
}