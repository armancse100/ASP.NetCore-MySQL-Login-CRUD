﻿using InventoryManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

public class InventoryManagementDbContext : IdentityDbContext<User, Role, int>
//public class InventoryManagementDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, UserToken>
{
    //Table List
    public DbSet<Employee> Employies { get; set; }
    public DbSet<ProductCategory> ProductCategorys { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Entry> Entries { get; set; }
    public DbSet<Exit> Exits { get; set; }
    /*public DbSet<User> Uses { get; set; }
    public DbSet<Role> Roles { get; set; }*/
    //Table List End

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
    : base(options)
    {}

    //Fluent API to make Composite Key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Key automatic generation configuration
        /*
        modelBuilder.Entity<Employee>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
        */

        /*-------------------------------------------*/

        //many to many relation configuration
        /*
            modelBuilder.Entity<Country>(e =>
            {
                e.HasAlternateKey(c => new { c.BengaliName });
                e.HasAlternateKey(c => new { c.EnglishName });
                e.HasAlternateKey(c => new { c.ShortName });
            });

            modelBuilder.Entity<CountryPerson>(cp =>
            {
                cp.HasOne(p => p.Person).WithMany(c => c.VisitedCountries).HasForeignKey(p => p.PersonID);
                cp.HasOne(c => c.Country).WithMany(p => p.Visitors).HasForeignKey(c => c.CountryID);

                //For Ensuring only 1 entry per person
                cp.HasAlternateKey(c => new { c.CountryID, c.PersonID });
            });
        */
    }
}