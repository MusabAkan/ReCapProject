using Core.Utilities.Results;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color Color);
        IResult Update(Color Color);
        IResult Delete(Color Color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
    }
}
