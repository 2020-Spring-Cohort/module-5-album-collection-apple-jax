﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext db;

        public Repository(DbContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Set<T>().Count();
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            // Save will persist all modifications to entities to the database.
            // Theres no great way to test this, and really we would be testing Microsoft's
            // code and not ours.  Untested code is the exception, not the norm.
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        // Sam- can you check this syntax for return of data from GetAll to the
        // original GetAll action in your Controller?  
        // I believe Controller is expecting return type to be wrapped in a Task.

        //public async Task<IEnumerable<T>> GetAll()
        //{
        //    return await db.Set<T>().ToListAsync();
        //}


    }
}
