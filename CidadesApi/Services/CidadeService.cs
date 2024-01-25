using System.Text.Json;
using cidadesapi.Models;

namespace cidadesapi.Services
{
	public class CidadeService : ICidadeService
	{
		
		private readonly List<Cidade> cidadeList;
		
		public CidadeService()		
		{
			cidadeList = JsonRead();
		} 
		
		public List<Cidade> GetAll() 
		{
			return cidadeList;	
		}
		 
		public Cidade? GetById(int id)
		{
		    
			return cidadeList != null ? cidadeList?.FirstOrDefault(x =>x.IdCidade == id) : null  ;			
		}
		 
		public List<Cidade> GetByCondition(Func<Cidade,bool> condition) 
		{
			return cidadeList.Where(condition).ToList();
		}
		 
		private List<Cidade>? JsonRead()		 
		{
		 	var lstCidades = File.ReadAllText(@"Data/cidades.json");
			var resultData =  JsonSerializer.Deserialize<ListaCidades>(lstCidades);  
			 
			return resultData?.Cidades;
		}
	}
}

