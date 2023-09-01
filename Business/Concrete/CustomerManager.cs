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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            customerDal.Remove(customer);
            return new ErrorResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(customerDal.GetAll());
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            return new SuccessDataResult<Customer>(customerDal.Get(p=>p.Id == id));
        }

        public IResult Update(Customer customer)
        {
            customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
