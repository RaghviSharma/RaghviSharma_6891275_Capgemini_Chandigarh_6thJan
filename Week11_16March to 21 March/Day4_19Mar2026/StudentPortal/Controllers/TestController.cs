using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		[HttpGet]
		[Authorize(AuthenticationSchemes = "Bearer")]
		public IActionResult GetData()
		{
			return Ok("Secure API Data 🔐");
		}
	}
}