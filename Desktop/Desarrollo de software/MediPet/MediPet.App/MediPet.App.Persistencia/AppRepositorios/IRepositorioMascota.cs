using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MediPet.App.Dominio;

namespace MediPet.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);    
        Mascota GetMascota(int idMascota);
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);
        IEnumerable<Mascota> GetMascotasMachos();
        IEnumerable<Mascota> GetMascotasPerros();
       
    }


}