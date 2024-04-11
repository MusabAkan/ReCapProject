using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _dal;
        public BrandManager(IBrandDal dal)
        {
            _dal = dal;
        }
        public void Add(Brand brand)
        {
            _dal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _dal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _dal.GetList();
        }

        public Brand GetById(int brandId)
        {
            return _dal.Get(i => i.Id == brandId);
        }

        public void Update(Brand brand)
        {
            _dal.Update(brand);
        }
    }
}
