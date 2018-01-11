using Microsoft.EntityFrameworkCore;
using System;

public class InventoryManagementDbContext : DbContext
{
    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
    : base(options)
    {
        //Migration - create Tables
        try
        {
            this.Database.EnsureDeleted();
            // Migrate the database
            this.Database.EnsureCreated();
            this.Database.Migrate();
        }
        catch (Exception ex)
        {
        }
    }
}