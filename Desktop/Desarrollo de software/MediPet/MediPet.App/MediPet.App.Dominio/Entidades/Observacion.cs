using System;
namespace MediPet.App.Dominio;
public class Observacion
{
    public int Id {get;set;}
    /// Fecha y hora en que se realizó la observación
    public DateTime FechaHora  {get;set;} 
    public SignoAlarma Sintomas {get;set;} 
    public string Descripcion {get;set;}
}