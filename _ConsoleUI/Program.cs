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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",car.ColorId,car.BlandId,car.DailyPrice,car.Descriptions,car.ModelYear,car.Id);
            }
            carManager.Add(new Car{Id=1,BlandId=1,ColorId=1,DailyPrice=1,Descriptions="yasin",ModelYear="1999" });


        }
    }
}
