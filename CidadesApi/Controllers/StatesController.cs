using Microsoft.AspNetCore.Mvc;
using cidadesapi.Models;
using cidadesapi.Services;

namespace cidadesapi.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class StatesController : Controller
	{
		IStatesService _statesService;
		
		public StatesController(IStatesService statesService)		
		{
			_statesService = statesService;
		}
		
		[HttpGet]
		public List<Estado> GetAll()		
		{
			return _statesService.GetAll();
		}
		
		[HttpGet]
		public Estado GetById(int id)		
		{
			return _statesService.GetById(id);
		}
	}
}