﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace AlmacenListanco.BaseDatos
{
   public class GenericRepository <TEntity> where TEntity : class
    {
        //Repositorio generico que permite el acceso generico a cualquier tabla
        protected AlmacenContext context;
        DbSet<TEntity> dbSet;
        public GenericRepository(AlmacenContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

        }
        public void Delete(TEntity entityToDelete)
        {
            dbSet = context.Set<TEntity>();
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);

            context.Entry(entityToDelete).State = EntityState.Deleted;
            context.SaveChanges();

        }

        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            dbSet = context.Set<TEntity>();
            var entities = dbSet.Where(predicate).ToList();
            entities.ForEach(x => context.Entry(x).State = EntityState.Deleted);
            context.SaveChanges();

        }

        public void Create(TEntity entity)
        {
            try
            {
                dbSet = context.Set<TEntity>();
                dbSet.Add(entity);
               // context.SaveChanges();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }



        }

        public List<TEntity> GetAll()
        {
            return (List<TEntity>)context.Set<TEntity>().ToList();

        }
        public List<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            dbSet = context.Set<TEntity>();
            IQueryable<TEntity> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }

        }
        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            dbSet = context.Set<TEntity>();
            return dbSet.FirstOrDefault(predicate);
        }
    }
}