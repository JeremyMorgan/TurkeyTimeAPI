using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurkeyTimeAPI.Models
{
    [Table("FoodItems")]
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Person { get; set; }
        public bool GlutenFree { get; set; }
        public bool Vegetarian { get; set; }
    }
}
