using BookStoreDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI
{
    public static class DbInitializer
    {
        public static void Initialize(BookStoreDb.BookStoreContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.DeliveryMethods.Any())
            {
                return;   // DB has been seeded
            }

            var deliveryMethods = new DeliveryMethod[]
            {
                new DeliveryMethod{Name = "Motobike", BaseCost = 5, September = 1.5F, June = 0.5F, July = 0.5F, August = 0.5F },
                new DeliveryMethod{Name = "Train", BaseCost = 10, September = 1.8F, June = 0.8F, July = 0.8F, August = 0.8F },
                new DeliveryMethod{Name = "Aircraft", BaseCost = 20, September = 2F, June = 0.8F, July = 0.8F, August = 0.8F }
            };
            foreach (DeliveryMethod s in deliveryMethods)
            {
                context.DeliveryMethods.Add(s);
            }
            context.SaveChanges();
        }
    }
}
