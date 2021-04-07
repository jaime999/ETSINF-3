﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace GestDepLib.Persistence
{
    public class EntityFrameworkDAL : IDAL
    {
        private readonly DbContext dbContext;

        public EntityFrameworkDAL(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Insert<T>(T entity) where T : class
        {
            dbContext.Set<T>().Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            dbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return dbContext.Set<T>();
        }

        public T GetById<T>(IComparable id) where T : class
        {
            return dbContext.Set<T>().Find(id);
        }

        public bool Exists<T>(IComparable id) where T : class
        {
            return dbContext.Set<T>().Find(id) != null;
        }

        public void Clear<T>() where T : class
        {
            dbContext.Set<T>().RemoveRange(dbContext.Set<T>());
           
        }

        public void ClearPool<T>() where T : class
        {
            dbContext.Set<T>().RemoveRange(dbContext.Set<T>());
            dbContext.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Pools',RESEED,0);");
        }

        public void Commit()
        {
                dbContext.SaveChanges();
        }
    

        public IEnumerable<T> GetWhere<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

    }
}
