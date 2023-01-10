using GatasdaManu.Domain;
using GatasdaManu.Repository.Base;
using GatasdaManu.Repository.Interface;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//classe responsável por trazer todas as informações do banco de dados.

namespace GatasdaManu.Repository.Interface
{
    public class BandRepository : RepositoryBase<Banda>, IBandRepository
    {
        public BandRepository() : base(connectionString: "mongodb://localhost:27017/rocknroll", collectionName: "banda")
        {
        }

        public async Task<IEnumerable<Banda>> GetBandByName(string Name)
        {
            Expression<Func<Banda, bool>> expression = banda => banda.Name == Name;
            var result = await Find(expression);
            return result;
        }

        public async Task<IEnumerable<Banda>> GetBandByYear(int year)
        {
            Expression<Func<Banda, bool>> expression = banda => banda.Year == year;
            var result = await Find(expression);
            return result;
        }
    }
}


