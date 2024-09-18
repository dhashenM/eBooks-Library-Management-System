using eBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data
{
    //Creating a file that translates CS to SQL to send/receive data to/from the database
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Illustrator_Book>().HasKey(am => new
            {
                am.IllustratorId,
                am.BookId
            });

            modelBuilder.Entity<Illustrator_Book>().HasOne(b => b.Book).WithMany(am => am.Illustrators_Books).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Illustrator_Book>().HasOne(b => b.Illustrator).WithMany(am => am.Illustrators_Books).HasForeignKey(b => b.IllustratorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Illustrator> Illustrators { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Illustrator_Book> Illustrators_Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }


        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
