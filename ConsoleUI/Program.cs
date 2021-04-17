using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new InMemoryCarDal());

            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            
        }
    }
}
