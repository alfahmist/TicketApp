using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusHistory> StatusHistory { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // key 
            modelBuilder.Entity<Employee>()
            .HasIndex(e => e.Email)
            .IsUnique();

            // Ticket - Category
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tickets);
                
            // StatusHistory - Ticket
            modelBuilder.Entity<StatusHistory>()
                  .HasOne(st => st.Ticket)
                  .WithMany(t => t.StatusHistories)
                  .OnDelete(DeleteBehavior.Cascade);

            // StatusHistory - Status
            modelBuilder.Entity<StatusHistory>()
                  .HasOne(sh => sh.Status)
                  .WithMany(s => s.StatusHistories)
                  .OnDelete(DeleteBehavior.Cascade);

            // Message - Ticket
            modelBuilder.Entity<Message>()
                  .HasOne(m => m.Ticket)
                  .WithMany(t => t.Messages)
                  .OnDelete(DeleteBehavior.Cascade);

            // Message - Employee
            modelBuilder.Entity<Message>()
                  .HasOne(m => m.Employee)
                  .WithMany(e => e.Messages)
                  .OnDelete(DeleteBehavior.Cascade);

            // Employee - Role
            modelBuilder.Entity<Employee>()
                  .HasOne(e => e.Role)
                  .WithMany(r => r.Employees);
        
        }
    }
}
