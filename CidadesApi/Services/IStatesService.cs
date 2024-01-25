using cidadesapi.Models;

namespace cidadesapi.Services
{
	public interface IStatesService
	{
		 List<Estado> GetAll();
		 
		 Estado GetById(int id);
		 
		 List<Estado> GetByCondition(Func<Estado,bool> condition); 
	}
}