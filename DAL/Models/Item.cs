using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DueTo { get; set; }

        public DateTime? DoneAt { get; set; }

        public int ItemCollectionId { get; set; }

        public ItemCollection ItemCollection { get; set; } = null!;

        // Many to Many
        public List<ItemType> ItemTypes { get; set; } = new();

    }
}
