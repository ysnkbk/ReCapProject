using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using Entitites.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {

        List<CarDetailsDto> GetCarDetails();


    }
}
