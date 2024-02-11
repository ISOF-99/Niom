using Turin.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories
{
    internal class Reposi<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public Reposi(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual TEntity Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().FirstOrDefault(expression);
        }

        public virtual TEntity Update(Expression<Func<TEntity, bool>> expression, TEntity entity)
        {
            var entityToUpdate = _context.Set<TEntity>().FirstOrDefault(expression);
            if (entityToUpdate != null)
            {
                _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            return entityToUpdate;
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> expression)
        {
            var entityToDelete = _context.Set<TEntity>().FirstOrDefault(expression);
            if (entityToDelete != null)
            {
                _context.Remove(entityToDelete);
                _context.SaveChanges();
            }
        }
    }
}
