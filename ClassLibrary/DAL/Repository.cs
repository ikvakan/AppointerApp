using OICAR_Desktop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using OICAR_Desktop.Model;
using System.Data.Entity;

namespace OICAR_Desktop.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ModelContainer db;

        public Repository(ModelContainer modelContainer)
        {
            db= modelContainer;
        }
        public void Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            //db.Set<TEntity>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            
        }

       
    }
}
