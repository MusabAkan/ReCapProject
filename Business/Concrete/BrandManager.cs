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
            if (brand.Name.Length > 2)
                _dal.Add(brand);
            else
                throw new Exception("Araba ismi minimum 2 karakter olmalıdır");
        }
    }
}
