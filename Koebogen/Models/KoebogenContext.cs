using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Koebogen.Models
{

    public class KoebogenContext : DbContext
    {
       /*public KoebogenContext(DbContextOptions<KoebogenContext> options)
            : base(options)
        { }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connection = @"Server=localhost;Database=KBG;Trusted_Connection=True;ConnectRetryCount=0";
                optionsBuilder.UseSqlServer(connection);
            }
        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Group>()
            .HasOne(p => p.Project)
            .WithMany(g => g.Groups)
            .HasForeignKey(pg => pg.ProjectID);

                      modelBuilder.Entity<Category>()
                .HasOne(g => g.Group)
                  .WithMany(c => c.Categories)
                  .HasForeignKey(gc => gc.GroupID);

                      modelBuilder.Entity<Task>()
                .HasOne(g => g.Group)
                  .WithMany(t => t.Tasks)
                  .HasForeignKey(gt => gt.GroupID);

        }
        /*  protected override void OnModelCreating(Modelbuilder modelBuilder)
          {
              modelBuilder.Entity<Project>()
                  .HasMany(g => g.Groups)
                  .WithOne(p => p.Project)        
                  .IsRequired();
          }*/
    }
}
