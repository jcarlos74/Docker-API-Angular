using System.Linq;
using System.Text.Json;
using System.IO;
using cidadesapi.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace cidadesapi.Services
{
	public class StatesService : IStatesService
	{
		private readonly List<Estado> statesList;
		
		public StatesService()		
		{
			statesList = JsonRead();
		} 
		
		public List<Estado> GetAll() 
		{
			return statesList;	
		}
		 
		public Estado? GetById(int id)
		{
		    
			return statesList != null ? statesList?.FirstOrDefault(x =>x.Id == id) : null  ;			
		}
		 
		public List<Estado> GetByCondition(Func<Estado,bool> condition) 
		{
			return statesList.Where(condition).ToList();
		}
		 
		private List<Estado>? JsonRead()		 
		{
		 	var lstStates = File.ReadAllText(@"Data/estados.json");
			var resultData =  JsonSerializer.Deserialize<ListaEstados>(lstStates);  
			 
			return resultData?.Estados;
		}
		
	}
}