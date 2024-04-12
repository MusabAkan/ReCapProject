using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
