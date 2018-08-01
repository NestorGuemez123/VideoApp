﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoOnDemand.Entities
{
    public class Persona
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public bool? Status { get; set; }

        public ICollection<Media> Medias { get; set; }
    }
}
