using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Models
{
    public class Restauran
    {
        [Key]
        public int RestaurantId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string RestaurantName { get; set; }
        [Column("TypeName =nvarchar(200)")]
        public string Menu { get; set; }
        [Column("TypeName =nvarchar(100)")]
        public String food { get; set; }
        [Column("TypeName =nvarchar(100)")]
        public string drink { get; set; }
     
    } 
}