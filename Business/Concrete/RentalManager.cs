using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this.rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate == default)
            {
                return new ErrorResult("Geri dönüş tarihi olmadan araç kiralanamaz");
            }
            else
            {
                rentalDal.Add(rental);
                return new SuccessResult("Araç başarıyla kiralandı");
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(rentalDal.GetAll());
        }
    }
}
