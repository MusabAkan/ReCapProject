using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _dal;
        public UserManager(IUserDal dal)
        {
            _dal = dal;
        }
        public IResult Add(User User)
        {
            _dal.Add(User);
            return new SuccessResult();
        }
        public IResult Delete(User User)
        {
            _dal.Delete(User);
            return new SuccessResult();
        }
        public IDataResult<List<User>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<User>>(data); 
        }
        public IDataResult<User> GetById(int userId)
        {
            var data = _dal.Get(i => i.Id == userId);
            return new SuccessDataResult<User>(data);
        }
        public IResult Update(User User)
        {
           _dal.Update(User);   
            return new SuccessResult(); 
        }
    }
}
