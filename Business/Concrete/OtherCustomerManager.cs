using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class OtherCustomerManager : IOtherCustomerService
    {
        private readonly IOtherCustomerDal _dal;
        public OtherCustomerManager(IOtherCustomerDal dal)
        {
            _dal = dal;
        }
        public IResult Add(OtherCustomer Customer)
        {
            _dal.Add(Customer);
            return new SuccessResult();
        }
        public IResult Delete(OtherCustomer Customer)
        {
            _dal.Delete(Customer);
            return new SuccessResult();
        }
        public IDataResult<List<OtherCustomer>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<OtherCustomer>>(data);
        }
        public IDataResult<List<OtherCustomer>> GetByUserId(int userId)
        {
            var data = _dal.GetList(i => i.UserId == userId);
            return new SuccessDataResult<List<OtherCustomer>>(data);
        }
        public IResult Update(OtherCustomer Customer)
        {
            _dal.Update(Customer);
            return new SuccessResult();
        }
    }
}
