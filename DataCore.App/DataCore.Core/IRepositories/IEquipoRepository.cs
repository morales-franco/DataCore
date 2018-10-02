using DataCore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Core.IRepositories
{
    public interface IEquipoRepository
    {
        Equipo Get(long id);

        IList<Equipo> GetList();
    }
}
