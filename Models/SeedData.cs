using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace disinterest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new disinterestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<disinterestContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(

                    new Product
                    {
                        Name = "A Box",
                        Category = "Container",
                        ProductPage = "https://www.amazon.com/Willcomes-Wooden-Useless-Perpetual-Machine/dp/B01K4UYZ56?ref_=fsclp_pl_dp_5",
                        ImageURL = "https://images-na.ssl-images-amazon.com/images/I/61wtFdsVEKL._SL1132_.jpg",
                        Price = 20.99M,
                        Description = "With this useless box perpetual machine every " +
                        "time you flip the switch on, a little finger pops out and turns itself off."
                    },

                    new Product
                    {
                        Name = "A Can",
                        Category = "Container",
                        ProductPage = "https://www.amazon.com/Useless-Machine-in-a-Can/dp/B018XXG7WU?ref_=fsclp_pl_dp_7",
                        ImageURL = "https://images-na.ssl-images-amazon.com/images/I/81U7f0EmQAL._SL1500_.jpg",
                        Description = "The Useless Can is a DIY kit with 52 parts that you assemble without" +
                        " soldering to create a fun mechanism."
                    },

                    new Product
                    {
                        Name = "A James Blunt Album",
                        Category = "Music",
                        ProductPage = "https://www.amazon.com/Back-Bedlam-Explicit-James-Blunt/dp/B0011Z5ILO/ref=sr_1_1?keywords=james+blunt+album&qid=1568300984&sr=8-1",
                        ImageURL = "https://m.media-amazon.com/images/I/81fujsKUvtL._SS500_.jpg",
                        Price = 9.49M,
                        Description = "Back to Bedlam is loved my many people that no one likes."
                    },

                    new Product
                    {
                        Name = "Eat, Pray, Love",
                        Category = "Books",
                        ProductPage = "https://www.amazon.com/Eat-Pray-Love-Everything-Indonesia/dp/B000FDFY9O/ref=sr_1_1?crid=141IVQUHSAB6R&keywords=eat+love+pray+book&qid=1568301156&sprefix=eat+lo%2Caps%2C150&sr=8-1",
                        ImageURL = "https://images-na.ssl-images-amazon.com/images/I/51Rf-CybltL._SX342_.jpg",
                        Price = 13.99M,
                        Description = "Loved by many women that have still yet to leave there hometown."
                    }

                ); ;
                context.SaveChanges();
            }
        }
    }
}

