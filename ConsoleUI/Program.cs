using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { BrandId = 2, ColorId = 4, ModelYear = 2021, DailyPrice = 1236, Description = "Dizel" };
            //CarManager car = new CarManager(new InMemoryCarDal());
            CarManager carm = new CarManager(new EfCarDal());

            //foreach (var item in car.GetAll())
            //{
            //    Console.WriteLine(item);
            //}


            //carm.Add(car);
            foreach (var item in carm.GetAll())
            {
                Console.WriteLine(item);
            }
            foreach (var item in carm.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.Description);
            }
           
            
        }
    }
}
