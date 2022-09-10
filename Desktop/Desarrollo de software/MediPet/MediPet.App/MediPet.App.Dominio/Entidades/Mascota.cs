using System;
namespace MediPet.App.Dominio;
public class Mascota
{
    public int Id {get;set;}
    public Tipo Tipo {get;set;}
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public Genero Genero {set;get;}
    public string Procedencia {get;set;}
    /// Relacion entre la Mascota y su Cuidador
    public Cuidador Cuidador {get;set;}
    /// Relacion entre la Mascota y el Veterinario
    public Veterinario Veterinario {get;set;}
    /// Relacion entre Mascota y su Historia clínica
    public Historia Historia {get;set;}
    ///  Referencia a la lista de Observaciones de la Mascota 
    public System.Collections.Generic.List<Observacion> ObservacionesImportantes {get;set;}
    
}