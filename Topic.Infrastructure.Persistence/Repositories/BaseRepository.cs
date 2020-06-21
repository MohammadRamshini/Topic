using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Topic.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<Tkey, Tentity> : IRepository<Tkey, Tentity> where Tentity : class
    {
        private readonly TopicContext _context;
        public BaseRepository(TopicContext context)
        {
            _context = context;
        }
        public void Create(Tentity entity)
        {
            _context.Add(entity);
        }

        public void Delete(Tentity entity)
        {
            _context.Remove(entity);
        }

        public void Update(Tentity entity)
        {
            _context.Update(entity);
        }

        public bool Exists(Expression<Func<Tentity, bool>> expression)
        {
            var query = _context.Set<Tentity>().AsQueryable();
            query = query.Where(expression);
            return query.Any();
        }

        public Tentity Get(Tkey id)
        {
            return _context.Find<Tentity>(id);
        }

        public List<Tentity> Get(Expression<Func<Tentity, bool>> expression)
        {
            var query = _context.Set<Tentity>().AsQueryable();
            query = query.Where(expression);
            return query.ToList();
        }

        public IEnumerable<Tentity> GetAll()
        {
            return _context.Set<Tentity>().ToList();
        }

        public bool IsDuplicated(Expression<Func<Tentity, bool>> expression)
        {
            var query = _context.Set<Tentity>().AsQueryable();
            return query.Any(expression);
        }

        public void SavaChanges()
        {
            _context.SaveChanges();
        }
    }
}
