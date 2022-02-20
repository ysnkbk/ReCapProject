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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                if (entity.Descriptions.Length>2 && entity.DailyPrice>0)
                {
                    var addToEntity = context.Entry(entity);
                    addToEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                else 
                {
                    Console.WriteLine("Try Again");

                }

            }

        }

        public void Delete(Car entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                var deleteToEntity = context.Entry(entity);
                deleteToEntity.State = EntityState.Deleted;
                context.SaveChanges();



            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                var updateToEntity = context.Entry(entity);
                updateToEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
