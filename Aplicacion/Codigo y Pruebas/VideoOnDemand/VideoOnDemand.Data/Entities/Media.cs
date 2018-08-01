using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOnDemand.Entities
{
    abstract public class Media
    {
        public int? MediaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
<<<<<<< HEAD
=======
        public int DuracionMin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaLanzamiento { get; set; }
>>>>>>> 8ccc4eee3010995d95193345c6d49e2cfbb3d011
        public int? DuracionMin { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaLanzamiento { get; set; }
        public bool Activo { get; set; }

        public ICollection<Genero> Generos { get; set; }
        //public ICollection<Persona> Actores { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 8ccc4eee3010995d95193345c6d49e2cfbb3d011
    }
}
