using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllCars();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetCarByColorId(int id);
        IDataResult<Car> GetCarByBrandId(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IResult DeleteById(int id);
    }
}
