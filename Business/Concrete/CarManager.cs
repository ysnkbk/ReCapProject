﻿using Business.Abstract;
using DataAccess_.Abstract;
using DataAccess_.Concrete.InMemory;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

             
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
