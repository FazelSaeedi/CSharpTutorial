using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Framework.Domain;

namespace Framework.Infrastructure
{
    public class RepositoryBase<Tkey , T> : IRepository<Tkey, T> where T : class
    {

        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public T Get(Tkey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Delete(Tkey id )
        {
            var result = _context.Find<T>(id);

            _context.Remove(result);
            _context.SaveChanges();
        }
    }
}
