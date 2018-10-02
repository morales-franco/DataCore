using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.Entities
{
    public class Division
    {
        public int DivisionId { get; set; }
        public string Descripcion { get; set; }

        public List<Equipo> Equipo { get; set; }
    }
}
