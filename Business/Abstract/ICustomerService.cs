using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer Customer);
        IResult Update(Customer Customer);
        IResult Delete(Customer Customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetByUserId(int userId);
    }
}
