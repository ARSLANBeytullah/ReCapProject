using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //Global variable
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId= 1,ColorId = 1, DailyPrice = 120, Description ="Normal araba" ,ModelYear=2012},
                new Car{Id = 2,BrandId= 1,ColorId = 3, DailyPrice = 133, Description ="İyi araba" ,ModelYear=2013},
                new Car{Id = 3,BrandId= 2,ColorId = 5, DailyPrice = 145, Description ="Baya iyi araba" ,ModelYear=2015},
                new Car{Id = 4,BrandId= 2,ColorId = 2, DailyPrice = 200, Description ="Çok iyi araba" ,ModelYear=2018},
                new Car{Id = 5,BrandId= 2,ColorId = 1, DailyPrice = 250, Description ="Kiralanabilecek en iyi araba" ,ModelYear=2021}
            };
        }





        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();

        }

        public List<Car> GettAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        void ICarDal.GetById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
