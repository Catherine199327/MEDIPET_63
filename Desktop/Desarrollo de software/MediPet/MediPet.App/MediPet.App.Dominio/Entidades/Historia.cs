using System.Collections.Generic;
namespace MediPet.App.Dominio;
public class Historia
{
        public int Id {get;set;}
        public DateTime FechaHora  {get;set;}
        public string Antecedentes  {get;set;} 
        public string Alimentacion {get;set;}
        public float Peso {get;set;}
        /// Referencia a la lista de Sugerencias a seguir
        public List<SugerenciaCuidado> Sugerencias {get;set;} 
}