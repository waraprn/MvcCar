using System;
using System.Data.Entity;

namespace MvcCar.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}