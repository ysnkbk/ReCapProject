using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {

            using (EntityUSeContext context = new EntityUSeContext())
            {
                var addToEntity = context.Entry(entity);
                addToEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Color entity)
        {
            using (EntityUSeContext context = new EntityUSeContext())
            {
                var deleteToEntity = context.Entry(entity);
                deleteToEntity.State = EntityState.Deleted;
                context.SaveChanges();



            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (EntityUSeContext context = new EntityUSeContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (EntityUSeContext context = new EntityUSeContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (EntityUSeContext context = new EntityUSeContext())
            {
                var updateToEntity = context.Entry(entity);
                updateToEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
