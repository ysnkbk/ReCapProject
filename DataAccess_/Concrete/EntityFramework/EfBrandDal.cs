using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (EntityUSeContext context = new EntityUSeContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);

            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
               var updateContext = context.Entry(entity);
               updateContext.State = EntityState.Modified;
               context.SaveChanges();

            }
        }
    }
}
