using System;
namespace MediPet.App.Dominio;
public class SugerenciaCuidado
{
    public int Id {get;set;}
    /// Fecha y hora en la que se escriben las sugerencias
    public DateTime FechaHora  {get;set;}
    public string Diagnostico {get;set;}
    public string Recomendacion {get;set;}
}