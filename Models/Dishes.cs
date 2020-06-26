using System.ComponentModel.DataAnnotations;
using System;

namespace Crudelicious.Models
{

    public class Dishes
    {
        [Key]
        public int DishesId { get; set; }


        public string Name { get; set; }
        public string Chef { get; set; }
        public int Tastiness { get; set; }
        [Required]
        public int Calories { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
    }
}