using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Framework.Domain
{
    public interface IRepository<in Tkey,Tentity>
    {
        Tentity Get(Tkey id);
        List<Tentity> Get(Expression<Func<Tentity, bool>> expression);
        IEnumerable<Tentity> GetAll();
        bool IsDuplicated(Expression<Func<Tentity, bool>> expression);
        bool Exists(Expression<Func<Tentity, bool>> expression);
        void Create(Tentity entity);
        void Update(Tentity entity);
        void Delete(Tentity entity);
        void SavaChanges();
    }
}
