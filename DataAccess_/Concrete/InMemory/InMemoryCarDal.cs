using DataAccess.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1,BlandId=1,ColorId=200,ModelYear="1999",DailyPrice=50000,Descriptions="Old"},
                new Car{Id=2,BlandId=2,ColorId=201,ModelYear="2000",DailyPrice=51000,Descriptions="Young"},
                new Car{Id=3,BlandId=3,ColorId=202,ModelYear="2001",DailyPrice=52000,Descriptions="Child"},
                new Car{Id=4,BlandId=4,ColorId=203,ModelYear="2002",DailyPrice=53000,Descriptions="New" },
                new Car{Id=5,BlandId=5,ColorId=204,ModelYear="2003",DailyPrice=54000,Descriptions="Super"}


            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
         
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
