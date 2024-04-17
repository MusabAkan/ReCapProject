using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
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

        [LogAspect(typeof(FileLogger))]
        [CacheAspect(duration: 10)]
        [SecuredOperation("admin,editor")]
        public IResult Add(Brand brand)
        {
            _dal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _dal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var data = _dal.GetList();
            return new SuccessDataResult<List<Brand>>(data);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var data = _dal.Get(i => i.Id == brandId);
            return new SuccessDataResult<Brand>(data);
        }

        public IResult Update(Brand brand)
        {
            _dal.Update(brand);
            return new SuccessResult();
        }
    }
}
