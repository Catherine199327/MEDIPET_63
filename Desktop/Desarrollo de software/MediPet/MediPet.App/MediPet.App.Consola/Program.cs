// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

/*
using System;
using HospiEnCasa.App.Dominio;

namespace MediPet.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World EF!");
        }
    }

}

*/

// See https://aka.ms/new-console-template for more information

using System;
using MediPet.App.Dominio;
using MediPet.App.Persistencia;
using System.Collections.Generic;

/*namespace HospiEnCasa.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World EF!");
        }
    }

}
*/

namespace MediPet.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World EF!");
            //AddMascota();
            //ListarMascotasPerro()
            //ListarMascotasMachos();
            //AddSignosMascota(2);
            //AddMascotaConSintomas();   
            //AddMascotaConVeterinario();          
            //AddMascota();
            BuscarMascota(1);
            //AsignarVeterinario(1);

        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Tipo = Tipo.Gato,
                Nombre = "Marli",
                Edad = 2,
                Genero = Genero.Hembra,
                Procedencia = "Comprado en veterinaria"
            };
            _repoMascota.AddMascota(mascota);

        }

        private static void AddMascotaConVeterinario()
        {
            var mascota = new Mascota
            {
                Tipo = Tipo.Pez,
                Nombre = "Bob",
                Edad = 4,
                Genero = Genero.Macho,
                Procedencia = "De la calle",
                Veterinario = new Veterinario{Nombres="Julia",Apellidos="Tobon",Direccion="Calle 12#15",Email="julia@prog.com",NumeroContacto="3135343165",NombreVeterinaria="Los animales felices",Especialidad="Peces",Registro="56qw"},
                
            };
            _repoMascota.AddMascota(mascota);

        }

        private static void AddMascotaConSintomas()
        {
            var mascota = new Mascota
            {
                Tipo = Tipo.Pez,
                Nombre = "Lilu",
                Edad = 1,
                Genero = Genero.Hembra,
                Procedencia = "Comprado en la veterinaria",
                ObservacionesImportantes = new List<Observacion> {
                    new Observacion{FechaHora= new DateTime(2021,03,11,11,50,0),Descripcion="No se mueve",Sintomas=SignoAlarma.TemperaturaCorporal},
                    new Observacion{FechaHora= new DateTime(2021,05,22,12,50,0),Descripcion="Maulla mucho",Sintomas=SignoAlarma.Vomito},
                    new Observacion{FechaHora= new DateTime(2021,06,26,15,50,0),Descripcion="No quiere comer",Sintomas=SignoAlarma.Diarrea}

                }
            };
            _repoMascota.AddMascota(mascota);

        }

        private static void ListarMascotasMachos()
        {
            var mascotasM = _repoMascota.GetMascotasMachos();
            foreach (Mascota p in mascotasM)
            {
                Console.WriteLine(p.Nombre + "Edad en anos: " + p.Edad);
            }

        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre);
        }
        
/*
        private static void ListarMascotasMachos()
        {
            var mascotasM = _repoMascota.GetMascotasMachos();
            foreach (Mascota p in mascotasM)
            {
                Console.WriteLine(p.Nombre + "Edad en anos: " + p.Edad);
            }

        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1, 2);
            Console.WriteLine(veterinario.Nombre + " " + veterinario.Apellidos);
        }

        
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre);
        }
*/




/*
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }






        */

    }

}