using Business.Abstract;
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

        public void Add(Color color)
        {
            _dal.Add(color);
        }

        public void Delete(Color color)
        {
            _dal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _dal.GetList();
        }

        public Color GetById(int colorId)
        {
            return _dal.Get(i => i.Id == colorId);
        }

        public void Update(Color color)
        {
            _dal.Update(color);
        }
    }
}
