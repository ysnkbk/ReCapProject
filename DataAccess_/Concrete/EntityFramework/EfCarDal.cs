using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entitites.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EntityUSeContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (EntityUSeContext context=new EntityUSeContext())
            {
                var result = from c in context.Cars
                             join o in context.Color
                             on c.ColorId equals o.ColorId
                             join b in context.Brand
                             on c.BlandId equals b.BrandId
                             select new CarDetailsDto { BrandName = b.BrandName, ColorName = o.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();



            }
        }

        
    }
}
