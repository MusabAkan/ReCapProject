using Core.Utilities.Results;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User User);
        IResult Update(User User);
        IResult Delete(User User);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
    }
}
