

namespace DAL.Models
{
    public class ItemCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Item> Items { get; set; } = new();
    }
}
