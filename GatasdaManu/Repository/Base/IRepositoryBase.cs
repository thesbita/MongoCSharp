using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GatasdaManu.Repository.Base
{
    public interface IRepositoryBase <T> where T : class
    {
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression); //Ele tem como função retornar uma lista de T (qualquer objeto que seja uma classe). 
    }
}
