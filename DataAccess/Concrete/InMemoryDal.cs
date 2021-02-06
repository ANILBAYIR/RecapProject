using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=1000, Description="Spor araba"},
                new Car{ Id=2, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=700, Description="SUV araba"},
                new Car{ Id=3, BrandId=1, ColorId=4, ModelYear=2012, DailyPrice=500, Description="Sedan araba"},
                new Car{ Id=4, BrandId=3, ColorId=2, ModelYear=2009, DailyPrice=300, Description="Eski araba"},
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

        public List<Car> GetAll()
        {
            return _cars;
        }
                
        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
