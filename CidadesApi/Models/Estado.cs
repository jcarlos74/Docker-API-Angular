using System;
using System.Text.Json.Serialization;
namespace cidadesapi.Models
{
	public class ListaEstados
	{
		[JsonPropertyName("estados")]
		public List<Estado> Estados {get;set;}
	}
	
	public class Estado
	{
		[JsonPropertyName("id")]
  		public int Id {get;set;}	
		[JsonPropertyName("nome")]	
		public string? Nome { get; set; }
		[JsonPropertyName("sigla")]	
		public string? Sigla { get; set; }
	}
}