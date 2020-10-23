using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Models
{
    public class Restaurant : DbContext
    {

        public Restaurant(DbContextOptions<Restaurant> options) : base(options)
        {

        }
        public DbSet<Restauran> Restaurans { get; set; }



    }  
}