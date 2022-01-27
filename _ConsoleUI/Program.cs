using DataAccess_.Concrete.InMemory;
using Entitites.Concrete;
using Business.Concrete;

using System;

namespace _ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
            

        }
    }
}
