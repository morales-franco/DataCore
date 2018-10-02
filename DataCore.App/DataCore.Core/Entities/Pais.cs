using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.Entities
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nombre { get; set; }

        public List<Equipo> Equipo { get; set; }
    }
}
