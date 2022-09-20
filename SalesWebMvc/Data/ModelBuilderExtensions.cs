using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Technology" },
                new Department { Id = 2, Name = "Finance" },
                new Department { Id = 3, Name = "Marketing"}
            );

            modelBuilder.Entity<Seller>().HasData(
                new Seller { Id = 1, Name = "Guizinho", Email = "gui@gmail.com", BirthDate = new DateTime(2000, 10, 1), BaseSalary = 8000.0, DepartmentId = 1 },
                new Seller { Id = 2, Name = "Stezinha", Email = "ste@gmail.com", BirthDate = new DateTime(2003, 7, 23), BaseSalary = 4500.0, DepartmentId = 2 },
                new Seller { Id = 3, Name = "Solzinha", Email = "sol@gmail.com", BirthDate = new DateTime(1989, 2, 13), BaseSalary = 3000.0, DepartmentId = 3 }
            );

            modelBuilder.Entity<SalesRecord>().HasData(
                new SalesRecord { Id = 1, Date = new DateTime(2022, 10, 12), Amount = 2500.0, Status = SaleStatus.Billed, SellerId = 1 },
                new SalesRecord { Id = 2, Date = new DateTime(2022, 7, 18), Amount = 1200.0, Status = SaleStatus.Pending, SellerId = 2 },
                new SalesRecord { Id = 3, Date = new DateTime(2022, 9, 11), Amount = 1000.0, Status = SaleStatus.Canceled, SellerId = 3 }
            );
        }
    }
}
