using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOnDemand.Entities
{
    abstract public class Media
    {
        public int MediaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int DuracionMin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaLanzamiento { get; set; }
    }
}
