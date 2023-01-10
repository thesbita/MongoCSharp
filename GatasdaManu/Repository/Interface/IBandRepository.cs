using GatasdaManu.Domain;
using GatasdaManu.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A interface será o contrato da nossa classe. Ela define as obrigações de uma classe. 

namespace GatasdaManu.Repository.Interface
{
    public interface IBandRepository : IRepositoryBase<Banda>
    {
        Task<IEnumerable<Banda>> GetBandByYear(int year);
        Task<IEnumerable<Banda>> GetBandByName(string name);
    }
}
