using Business.Abstract;
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
        public IResult Add(Customer Customer)
        {
            _dal.Add(Customer);
            return new SuccessResult();
        }
        public IResult Delete(Customer Customer)
        {
            _dal.Delete(Customer);
            return new SuccessResult();
        }
        public IDataResult<List<Customer>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Customer>>(data);
        }
        public IDataResult<List<Customer>> GetByUserId(int userId)
        {
            var data = _dal.GetList(i => i.UserId == userId);
            return new SuccessDataResult<List<Customer>>(data);
        }
        public IResult Update(Customer Customer)
        {
            _dal.Update(Customer);
            return new SuccessResult();
        }
    }
}
