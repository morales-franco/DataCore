using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.Dto.Index
{
    public class EquipoViewIndex
    {
        public long EquipoId { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Division { get; set; }
        public DateTime? FechaInaguracion { get; set; }

    }
}
