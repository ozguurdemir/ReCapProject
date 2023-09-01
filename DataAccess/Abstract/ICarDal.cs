using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepo<Car>
    {
        Car GetCarByBrandId(Expression<Func<Car, bool>> filter);
        Car GetCarByColorId(Expression<Func<Car, bool>> filter);
        List<CarDetailsDto> GetCarDetails();
        
    }
}
