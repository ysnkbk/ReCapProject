using Entitites.Concrete;
using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;

namespace _ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManager();
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager2.GetAllDetails())
            {
                Console.WriteLine("Brand Name=> {0} Color Name =>{1} Deaily Price =>{2}",car.BrandName,car.ColorName,car.DailyPrice);
            }

        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(7))
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", car.ColorId, car.BlandId, car.DailyPrice, car.Descriptions, car.ModelYear, car.Id);
            }

            carManager.Add(new Car { ColorId = 11, BlandId = 11, DailyPrice = 14000, Descriptions = "null", ModelYear = "2012" });
            carManager.Delete(new Car { Id = 11 });
            carManager.Update(new Car { ColorId = 1, BlandId = 1, DailyPrice = 14000, Descriptions = "null", ModelYear = "2012", Id = 1 });
        }
    }
}
