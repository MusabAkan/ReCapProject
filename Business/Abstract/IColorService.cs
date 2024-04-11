using Entities.Concrete;
namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color Color);
        void Update(Color Color);
        void Delete(Color Color);
        List<Color> GetAll();
        Color GetById(int colorId);
    }
}
