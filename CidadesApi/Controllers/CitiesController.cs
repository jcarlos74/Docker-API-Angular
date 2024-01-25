using System.Linq.Expressions;
using cidadesapi.Models;
using cidadesapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace cidadesapi.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class CitiesController  : Controller
	{
		
		ICidadeService _cidadeService;
		
		public CitiesController(ICidadeService cidadeService)		
		{
			_cidadeService = cidadeService;
		}
		
		[HttpGet]
		public List<Cidade> GetAll()		
		{
			return _cidadeService.GetAll();
		}
		
		[HttpGet]
		public Cidade GetById(int id)		
		{
			return _cidadeService.GetById(id);
		}
		
		/// <summary>
		///  Retorna Cidades conforme os filtros passados
		/// </summary>
		/// <param name="nome">Parte do Nome da Cidade</param>
		/// <returns></returns>
		[HttpGet]
		public List<Cidade> GetByConditions(string nome ) 
		{
		 	return _cidadeService.GetByCondition(c => c.Name.ToUpper().StartsWith(nome.ToUpper()));
		}
		
	}
}