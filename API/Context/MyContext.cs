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
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketMessage> TicketMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ticket - Status
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tickets);

            // Ticket - Category
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Status)
                .WithMany(s => s.Tickets);

            // Ticket - TicketMessage
            modelBuilder.Entity<Ticket>()
                .HasMany(t => t.TicketMessage)
                .WithOne(tm => tm.Ticket);
            
            // Ticket - Message
            modelBuilder.Entity<TicketMessage>()
                .HasOne(tm => tm.Messages)
                .WithMany(m => m.TicketMessages);

            // Message - Employee
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Employee)
                .WithMany(e => e.Messages);

            // Employee - Role
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Role)
                .WithMany(r => r.Employees);
        }
    }
}
