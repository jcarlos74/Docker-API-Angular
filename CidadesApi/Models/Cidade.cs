using System;
using System.Text.Json.Serialization;
namespace cidadesapi.Models
{
	public class ListaCidades
	{
		[JsonPropertyName("cidades")]
		public List<Cidade> Cidades {get;set;}
	}
			
	public class Cidade
	{
		[JsonPropertyName("id_cidade")]
		public int IdCidade { get; set; }
		
		[JsonPropertyName("name")]
		public string Name { get; set; }
		
		[JsonPropertyName("id_estado")]
		public int IdEstado { get; set; }
		
	}
}