using Microsoft.EntityFrameworkCore;
using MultibleDbCRUD.Models.Abstract;
using MultibleDbCRUD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Repositories
{
    public class BaseRepository<TContext, T> : IBaseRepository<TContext, T> where TContext : DbContext where T : BaseEntity
    {
        private readonly TContext _context;
        private readonly DbSet<T> _entity;

        public BaseRepository(TContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public void Add(T value)
        {
            _entity.Add(value);
        }

        public T Find(string id)
        {
            return _entity.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsNoTracking().ToList();
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }

        public bool Update(T Value)
        {
            _entity.Update(Value);
            return true;
        }
    }
}
