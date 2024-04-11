using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOtherCustomerService
    {
        IResult Add(OtherCustomer customer);
        IResult Update(OtherCustomer customer);
        IResult Delete(OtherCustomer customer);
        IDataResult<List<OtherCustomer>> GetAll();
        IDataResult<List<OtherCustomer>> GetByUserId(int userId);
    }
}
