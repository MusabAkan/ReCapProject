using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _dal;
        public CustomerManager(ICustomerDal dal)
        {
            _dal = dal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer Customer)
        {
            _dal.Add(Customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Customer Customer)
        {
            var exists = _dal.Get(i => i.Id == Customer.Id);

            if (exists == null)
                return new ErrorResult(Messages.CustomerNotFound);

            _dal.Delete(Customer);
            return new SuccessResult(Messages.Deleted);
        }


        public IDataResult<List<Customer>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Customer>>(data);
        }
        public IDataResult<List<Customer>> GetByUserId(int userId)
        {
            var data = _dal.GetList(i => i.UserId == userId);
            if (data != null)
                return new SuccessDataResult<List<Customer>>(data);
            return new ErrorDataResult<List<Customer>>(Messages.UserNotFound);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Update(Customer Customer)
        {

            var exists = _dal.Get(i => i.Id == Customer.Id);
            if (exists == null)
                return new ErrorResult(Messages.CustomerNotFound);

            _dal.Update(Customer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
