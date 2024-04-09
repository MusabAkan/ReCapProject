using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        Brand GetById(int brandId);
        List<Brand> GetAll();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
