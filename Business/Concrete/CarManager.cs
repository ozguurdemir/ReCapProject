using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.CarPriceInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Remove(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult DeleteById(int id)
        {
            _carDal.RemoveByFilter(p=> p.CarId ==id);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed) ;
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.CarId == id));
        }

        public IDataResult<Car> GetCarByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetCarByBrandId(p=>p.BrandId==id));
        }

        public IDataResult<Car> GetCarByColorId(int id)
        {
            return new SuccessDataResult<Car>( _carDal.GetCarByColorId(p => p.ColorId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
