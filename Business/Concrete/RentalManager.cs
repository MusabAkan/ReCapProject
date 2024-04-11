using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _dal;
        public RentalManager(IRentalDal dal)
        {
            _dal = dal;
        }
        public IResult Add(Rental rental)
        {
            _dal.Add(rental);
            return new SuccessResult();
        }
        public IResult Delete(Rental rental)
        {
            _dal.Delete(rental);
            return new SuccessResult();
        }
        public IDataResult<List<Rental>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Rental>>(data);
        }
        public IDataResult<Rental> GetById(int rentalId)
        {
            var data = _dal.Get(i => i.Id == rentalId);
            return new SuccessDataResult<Rental>(data);
        }
        public IResult Update(Rental rental)
        {
            _dal.Add(rental);
            return new SuccessResult();
        }
    }
}
