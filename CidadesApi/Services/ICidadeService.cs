using cidadesapi.Models;

namespace cidadesapi.Services
{
	public interface ICidadeService
	{
		  List<Cidade> GetAll();
		 
		 Cidade GetById(int id);
		 
		 List<Cidade> GetByCondition(Func<Cidade,bool> condition); 
	}
}