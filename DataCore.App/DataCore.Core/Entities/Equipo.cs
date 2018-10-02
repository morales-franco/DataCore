using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.Entities
{
    public class Equipo
    {
        public long EquipoId { get; set; }
        public string Nombre { get; set; }
        public int PaisId { get; set; }
        public int DivisionId { get; set; }
        public DateTime? FechaInaguracion { get; set; }
        public Division Division { get; set; }
        public Pais Pais { get; set; }

    }
}
