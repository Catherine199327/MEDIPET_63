using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MediPet.App.Dominio;

namespace MediPet.App.Persistencia
{
    public class RepositorioMascota:IRepositorioMascota
    {
        /// Referencia al contexto de Mascota
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;

        }

        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
        }

        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                
                mascotaEncontrado.Tipo = mascota.Tipo;
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Edad = mascota.Edad;
                mascotaEncontrado.Genero = mascota.Genero;
                mascotaEncontrado.Procedencia = mascota.Procedencia;
                mascotaEncontrado.Veterinario = mascota.Veterinario;
                mascotaEncontrado.Historia = mascota.Historia;

                _appContext.SaveChanges();


            }
            return mascotaEncontrado;
        }


        Veterinario IRepositorioMascota.AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(p => p.Id == idMascota);
            if (mascotaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(m => m.Id == idVeterinario);
                if (veterinarioEncontrado != null)
                {
                    mascotaEncontrado.Veterinario = veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;
        }
        

        IEnumerable<Mascota> IRepositorioMascota.GetMascotasMachos()
        {

            return _appContext.Mascotas.Where(p => p.Genero == Genero.Macho).ToList();

        }

        IEnumerable<Mascota> IRepositorioMascota.GetMascotasPerros()
        {

            return _appContext.Mascotas.Where(p => p.Tipo == Tipo.Perro).ToList();

        }

/*
        public IEnumerable<Mascota> GetMascotasCorazon()
        {

            return _appContext.Mascotas
                                   .Where(p => p.SignosVitales.Any(s =>  TipoSigno.FrecuenciaCardica==s.Signo && s.Valor >=90))
                                   .ToList();
        }
*/         
    }
}