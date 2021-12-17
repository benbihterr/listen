using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using listen.Models;
using Microsoft.EntityFrameworkCore;

namespace listen.Data


{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Singer_Song>().HasKey(siso => new
            {
                siso.SingerId,
                siso.SongId
            });
            modelBuilder.Entity<Singer_Song>().HasOne(so => so.Song).WithMany(
                siso => siso.Singers_Songs).HasForeignKey(so => so.SongId);
            modelBuilder.Entity<Singer_Song>().HasOne(so => so.Singer).WithMany(
                siso => siso.Singers_Songs).HasForeignKey(si => si.SingerId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Singer_Song> Singers_Songs { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Record_Label> Record_Labels { get; set; }
    }
}
