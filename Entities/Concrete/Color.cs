using Core.Entities;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        public Color()
        {

        }
        public Color(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
