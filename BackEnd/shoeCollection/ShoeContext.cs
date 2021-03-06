﻿using Microsoft.EntityFrameworkCore;
using shoeCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shoeCollection
{
    public class ShoeContext : DbContext
    {
        public DbSet<ShoeType> ShoeTypes { get; set; }
        public DbSet<Shoe> Shoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ShoesCollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoeType>().HasData(

                new ShoeType()
                {
                    ShoeTypeId = 1,
                    ShoeTypeName = "Basketball"
                },

                new ShoeType()
                {
                    ShoeTypeId = 2,
                    ShoeTypeName = "Tennis"
                },

                new ShoeType()
                {
                    ShoeTypeId = 3,
                    ShoeTypeName = "Cross-trainer"
                },

                new ShoeType()
                {
                    ShoeTypeId = 4,
                    ShoeTypeName = "Running"
                });

            modelBuilder.Entity<Shoe>().HasData(

                new Shoe()
                {
                    ShoeId = 1,
                    ShoeTypeId = 1,
                    ShoeName = "Nike Air Force 1 Low",
                    ImagePath = "https://stockx-360.imgix.net/Nike-Air-Force-1-Low-Off-White-Black-White/Images/Nike-Air-Force-1-Low-Off-White-Black-White/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1546755764",
                    Description = "The Nike Air Force 1 Low is inarguably one of the most essential sneakers of all time. First debuting on the basketball court in 1982, the Air Force 1 quickly became a staple of the streets where it’s remained ever since. When sneaker technology progressed and the Air Force 1 was no longer commonly found on the court, it was then adopted by the sneaker fanatics and hip-hop kids in New York City in the mid ’80s. Since then, it’s gone on to be one of the most worn shoes ever, with millions of pairs sold worldwide. With its clean, simple – yet bold – look, the amazingly comfortable Air Force 1has become a true classic. If you don’t have a pair of Air Force 1’s, can you really even call yourself a sneakerhead? The Air Force 1 Low is most iconic in its simple white-on-white leather colorway, but the shoe has been produced in thousands of other color combinations, materials, and special edition modifications throughout its long and illustrious life. This timeless sneaker is a style staple, so if you can’t find a pair to match your own style, you just aren’t looking hard enough. You can shop a wide variety of color and material options for the legendary sneaker at Foot Locker now.",
                },

                new Shoe()
                {
                    ShoeId = 2,
                    ShoeTypeId = 4,
                    ShoeName = "Nike Epic React Flyknit",
                    ImagePath = "https://images.finishline.com/is/image/FinishLine/AQ0067_011?$Main_gray$",
                    Description = "The Nike Epic React Flyknit is at the forefront of Nike Running technology, featuring the brand’s new React Foam cushioning. The soft, energy-returning material offers all day comfort, whether you’re on run or wearing them casually. Already loved by core runners and casual sneaker wearers alike, React foam cushioning is featured in this sleek and sporty running shoe to make sure you look just as good as every step feels. The Epic React is constructed with a woven Flyknit upper that forms to the shape of your foot, giving you custom-adapted support and comfort in a lightweight and breathable material. Its foam outsole retains its shape and adds lightness to the shoe while rubber sections at the toe and heel provide traction and durability.The Nike Epic React Flyknit is available in a wide variety of colorways, from subdued to bright and colorful looks, ensuring everybody has a pair to match their style. The Epic React Flyknit makes running fun, thanks to its plush and snappy feel that pairs with the cutting-edge modern style and on-trend color options. Nike’s React foam is engineered to be extremely durable, resisting compression and keeping its shape to provide a brand-new feel even after 300 miles of use. Traditionally in white, the React foam midsole is also available in colored options on various styles. The Flyknit upper ranges from solid hues to multi-color options for each style."
                },

                new Shoe()
                {
                    ShoeId = 3,
                    ShoeTypeId = 2,
                    ShoeName = "Puma Avid evoKNIT",
                    ImagePath = "https://images.champssports.com/pi/39210100/zoom/puma-avid-evoknit-mens",
                    Description = "The PUMA Avid evoKNIT is at the forefront of sneaker technology with a design that blurs the lines between performance and fashion. The sleek and sporty silhouette combines a modern casual feel with performance technology from PUMA for a sneaker that’ll show your style is far more evolved than the rest of the crowd. With a speedy, running-inspired design, the Avid is constructed with a one-piece evoKNIT woven textile upper in a slip-on bootie style for a supportive, flexible, and breathable sock-like fit. The advanced properties of the shoe don’t end there, as the knit upper sits atop a full-length Ignite foam midsole, PUMA’s proprietary cushioning platform that provides a soft, energy-returning ride with comfort that lasts all day. The Ignite midsole is complemented by a flexible rubber outsole with a traction pattern that supplies multi-surface grip. The Avid evoKNIT is a multipurpose sneaker that’s perfect for your next session at the gym, or a stylish casual option for the streets. Either way, you can rest assured that it’s packed with PUMA’s latest technology for a supportive and well-cushioned performer. Ready to match anyone’s personal style, the Avid is available in a wide range of color combinations from solid hues to multicolor treatments, each just as memorable as the next. Evolve your sneaker style with the Avid evoKNIT."
                },

                new Shoe()
                {
                    ShoeId = 4,
                    ShoeTypeId = 3,
                    ShoeName = "Reebok Workout Plus",
                    ImagePath = "http://images.footlocker.com/pi/DV5242/zoom/DV5242.jpeg",
                    Description = "Since its original release in 1987, the Reebok Workout Plus has never gone out of style. The trainer has earned a committed UK fan base that loves the shoe in a comparable way to the U.S. market’s love for Air Jordan retros. The timeless feel of Reebok Classics allows the Workout Plus to look fantastic in any decade on any continent. A shoe that was ahead of its time, the Workout Plus’s designers sought to create a shoe capable of holding up to the rigors of cross training. They aimed for the ability to go straight from the weight room to a tennis court. This multi-sport functionality was possible because of Reebok’s patented “H-Strap” mid-foot unit. The H-Strap allowed wearers to tighten the strap for improved lateral movement or loosen the strap for a more traditional running shoe feel. Reebok would continue to expand their cross-training line to include other classics like the Ventilator and Graphlite Pro. Currently, Reebok is the leader in cross-training footwear. Choosing to grow with the rise of multi-exercise competitions, Reebok began sponsoring various Crossfit competitions and acting as their exclusive outfitter. They’ve devoted an entire line exclusively to Crossfit with fantastic shoes like the Crossfit Nano 8 and the Crossfit Nano 2.0, which can be traced back to the Workout Plus. The Workout Plus is known for its ultra-premium, soft, full-grain leather and classic Reebok UK flag branding. There’s something inherently fresh about the design of this low-top OG trainer. Don’t be fooled though, the Workout Plus has plenty of substance, with an EVA foam midsole for shock absorption and added comfort. A sturdy, high-abrasion rubber outsole secures every step. In recent years, Reebok has remixed the Workout Plus for a new generation with collaborations with hot rappers like Lil Yachty and Lil Baby under their “Alter The Icons” initiative. The Alter The Icons line strives to promote individual uniqueness. Yachty said it best, “I’m not moved by others opinion because it doesn’t make who I am.” "
                }


                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
