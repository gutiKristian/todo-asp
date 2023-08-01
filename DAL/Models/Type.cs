﻿using System.ComponentModel.DataAnnotations;


namespace DAL.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [MinLength(6), MaxLength(6)]
        public string ColorHex { get; set; }
    }
}
