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
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { 
            new Car{CarId=1,BrandId=1,ColorId=5,DailyPrice=275,Description="Araç..",ModelYear=2015},
            new Car{CarId=2,BrandId=2,ColorId=7,DailyPrice=300,Description="Araç..",ModelYear=2015},
            new Car{CarId=3,BrandId=3,ColorId=8,DailyPrice=150,Description="Araç..",ModelYear=2015},
            new Car{CarId=4,BrandId=4,ColorId=6,DailyPrice=250,Description="Araç..",ModelYear=2015},
            new Car{CarId=5,BrandId=5,ColorId=10,DailyPrice=200,Description="Araç..",ModelYear=2015}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p=>p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _car.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
