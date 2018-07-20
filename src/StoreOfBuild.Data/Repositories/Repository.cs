using System.Linq;
using StoreOfBuild.Data.Contexts;
using StroreOfBuild.Domain;
using System.Collections.Generic;

namespace StoreOfBuild.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public TEntity GetbyId(int id)
        {
            return _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
    }
}