using Business.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        InMemoryCarDal _inMemoryCarDal;

        public CarManager(InMemoryCarDal inMemoryCarDal)
        {
            _inMemoryCarDal = inMemoryCarDal;
        }
        public List<Car> GetAll()
        {
            return _inMemoryCarDal.GetAll();
        }

        public List<Car> GetById(int Id)
        {
            if (Id<5)
            {
                return _inMemoryCarDal.GetById(Id);
            }
            else
            {
                return null;
            }
        }
    }
}
