using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _dal;
        public ColorManager(IColorDal dal)
        {
            _dal = dal;
        }
        public IResult Add(Color color)
        {
            _dal.Add(color);
            return new SuccessResult();
        }
        public IResult Delete(Color color)
        {
            _dal.Delete(color);
            return new SuccessResult();
        }
        public IDataResult<List<Color>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Color>>(data);
        }
        public IDataResult<Color> GetById(int colorId)
        {
            var data = _dal.Get(i => i.Id == colorId);
            return new SuccessDataResult<Color>(data);
        }
        public IResult Update(Color color)
        {
            _dal.Update(color);
            return new SuccessResult();
        }
    }
}
