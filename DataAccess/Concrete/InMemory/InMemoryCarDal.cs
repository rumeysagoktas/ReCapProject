using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=0, BrandId=1,ColorId=2,DailyPrice=100,ModelYear=2020,Description="Super Model"},
                 new Car{Id=1, BrandId=2,ColorId=3,DailyPrice=200,ModelYear=2019,Description="Tam Model"},
                  new Car{Id=2, BrandId=3,ColorId=4,DailyPrice=300,ModelYear=2018,Description="Eski Model"},
                   new Car{Id=3, BrandId=4,ColorId=4,DailyPrice=400,ModelYear=2017,Description="Ultra Model"},
                    new Car{Id=4, BrandId=5,ColorId=5,DailyPrice=500,ModelYear=2016,Description="2.El Model"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

    

        public List<Car> GetById(int carId)
        {
           return _cars.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
