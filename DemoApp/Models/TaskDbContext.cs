﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DemoApp.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext() : base("DbConnection")
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();
        }
    }
}