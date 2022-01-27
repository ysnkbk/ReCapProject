using DataAccess_.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
    

namespace DataAccess_.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BlandId=1,ColorId=200,ModelYear="1999",DailyPrice=50000,Description="Old"},
                new Car{Id=2,BlandId=2,ColorId=201,ModelYear="2000",DailyPrice=51000,Description="Young"},
                new Car{Id=3,BlandId=3,ColorId=202,ModelYear="2001",DailyPrice=52000,Description="Child"},
                new Car{Id=4,BlandId=4,ColorId=203,ModelYear="2002",DailyPrice=53000,Description="New" },
                new Car{Id=5,BlandId=5,ColorId=204,ModelYear="2003",DailyPrice=54000,Description="Super"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);


        }

        public void Delete(Car car)
        {
            Car carToDelete=null;
            carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
                       
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
           return  _cars.Where(c => c.Id == carId).ToList();


        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BlandId = car.BlandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            



        }
    }
}
