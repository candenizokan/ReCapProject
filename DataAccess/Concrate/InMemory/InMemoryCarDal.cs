//using DataAccess.Abstract;
//using Entities.Concrate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrate.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1970, DailyPrice = 1856, Description = "Benzin"},
//                new Car {CarId = 2, BrandId = 2, ColorId = 4, ModelYear = 2021, DailyPrice = 1236, Description = "Dizel"},
//                new Car {CarId = 3, BrandId = 2, ColorId = 5, ModelYear = 1999, DailyPrice = 3698, Description = "LPG"},
//                new Car {CarId = 4, BrandId = 3, ColorId = 3, ModelYear = 2000, DailyPrice = 4141, Description = "Hibrit"},
//                new Car {CarId = 5, BrandId = 3, ColorId = 2, ModelYear = 2008, DailyPrice = 8855, Description = "Elektrik"},
//            };
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = null;
//            carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
//            _cars.Remove(carToDelete);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(p => p.CarId == Id).ToList();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
//            carToUpdate.CarId = car.CarId;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//        }
//    }
//}
