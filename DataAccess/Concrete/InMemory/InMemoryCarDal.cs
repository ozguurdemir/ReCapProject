using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 400, Description = "sedan", ModelYear = 2020 },
                new Car { CarId = 2, BrandId = 2, ModelYear=2022, Description="coupe", DailyPrice=600, ColorId=1},
                new Car { CarId = 3, BrandId = 3, ColorId=1, DailyPrice=500, ModelYear=2021, Description="sedan"}
                };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetCarByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetCarByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            Car carToGet = _cars.SingleOrDefault(p => p.CarId == id);
            return carToGet;
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Car entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveByFilter(Expression<Func<Car>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveByFilter(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void RemoveCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public void RemoveCarById(int id)
        {
            Car carToRemove = _cars.SingleOrDefault(p_ => p_.CarId==id);
            _cars.Remove(carToRemove);
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(p=> p.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            
        }
    }
}
