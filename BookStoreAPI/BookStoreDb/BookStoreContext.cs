using Microsoft.EntityFrameworkCore;
using System;

namespace BookStoreDb
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<ToDeliveryInfo> ToDeliveryInfos { get; set; }
        public DbSet<FromDeliveryInfo> FromDeliveryInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>(ent => {
                ent.HasIndex(i => i.OrderNumber).IsUnique(true);
                ent.HasMany(m => m.OrderDetails).WithOne(w => w.Order);
                ent.HasOne(h => h.DeliveryMethod).WithMany(w => w.Orders);
                ent.HasOne(h => h.FromDeliveryInfo).WithMany(w => w.Orders);
                ent.HasOne(h => h.ToDeliveryInfo).WithMany(w => w.Orders);
            });

        }
    }
}
