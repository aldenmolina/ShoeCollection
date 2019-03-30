﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoeCollection.Models;

namespace ShoeCollection
{
    public class ShoeContext : DbContext
    {
        public DbSet<ShoeBrand> ShoeBrands { get; set; }

        public DbSet<ShoeType> ShoesTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MemeDataBrogrammers;Trusted_Connection=True;";

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
                    ShoeTypeName = "Basketball Shoes",
                    TypeImagePath = "https://static1.squarespace.com/static/5717b2c82b8dde83cf76c2b2/5913bdd62994ca3a9fc3e64d/5913bdd7c534a5e3456902e7/1494466009609/titolo-swiss-sneaker-king-store-in-basel-1493369494-1.jpg",
                    ShoeTypeInfo = "Basketball shoes are stiff, heavy, and flat. They come up higher on the ankle than running shoes, to provide support for the stresses incurred by the ankle joint in basketball."
                },

                new ShoeType()
                {
                    ShoeTypeId = 2,
                    ShoeTypeName = "Running Shoes",
                    TypeImagePath = "http://savagehenrymagazine.com/wp-content/uploads/2015/03/Top-10-running-shoes-2014-cover.jpg",
                    ShoeTypeInfo = "Running shoes have a noticeable heel elevation built into the midsole, usually about 1 cm, that encourages the foot into forward motion. They also typically well cushioned all the way the forefoot. They are lightweight and have little to no provision for lateral motion support. They often have convex-curved outsoles, to encouragement forward motion, and are available with different outsole grip patterns, depending on whether they are intended for road running or trail running."
                },

                new ShoeType()
                {
                    ShoeTypeId = 3,
                    ShoeTypeName = "Cross-Training Shoes",
                    TypeImagePath = "https://honestlyfit.com/wp-content/uploads/2017/11/shoe-collage_small_v2-e1509491575681.jpg",
                    ShoeTypeInfo = "Cross-training shoes merge attributes from both running shoes and basketball shoes. The soles are flat with a slight heel elevation and extra heel cushioning. They are fairly flexible except in the fore-foot are due to a built in stabilizer for lateral motion. The outsole grip pattern on these shoes is usually also optimized for hard floors, with a weight lighter than basketball shoes but heavier/bulkier than running shoes. Some models have a higher rise, always lower than that of basketballl shoes, for ankle support."
                },

                new ShoeType()
                {
                    ShoeTypeId = 4,
                    ShoeTypeName = "Tennis Shoes",
                    TypeImagePath = "https://dailyburn.com/life/wp-content/uploads/2014/05/Summer-Shoes-Banner.jpg",
                    ShoeTypeInfo = "Tennis shoes are similar to cross-trainers with a lot of both forward and lateral motion but tend to be slightly stiffer than cross-trainers. They have flat bottoms and lower-profile midsoles, with less cushioning than basketball shoes or cross-trainers, due to the lower impact nature of tennis. Tennis is played on several different surfaces and so performance tennis footwear is made with outsole grip patterns optimized for grass, clay, and hard courts. Some tennis styles also have higher collars around the ankle to provide greater support there."
                });

            modelBuilder.Entity<ShoeBrand>().HasData(
                     new ShoeBrand()
                     {
                         ShoeTypeId = 1,
                         ShoeBrandId = 1,
                         ShoeBrandName = "Nike Air Force 1 Low",
                         BrandImagePath = "https://images.finishline.com/is/image/FinishLine/315123_111?$Main_gray$",
                         ShoeBrandInfo = "The Nike Air Force 1 Low is inarguably one of the most essential sneakers of all time. First debuting on the basketball court in 1982, the Air Force 1 quickly became a staple of the streets where it’s remained ever since. When sneaker technology progressed and the Air Force 1 was no longer commonly found on the court, it was then adopted by the sneaker fanatics and hip-hop kids in New York City in the mid ’80s. Since then, it’s gone on to be one of the most worn shoes ever, with millions of pairs sold worldwide. With its clean, simple – yet bold – look, the amazingly comfortable Air Force 1has become a true classic. If you don’t have a pair of Air Force 1’s, can you really even call yourself a sneakerhead? The Air Force 1 Low is most iconic in its simple white-on-white leather colorway, but the shoe has been produced in thousands of other color combinations, materials, and special edition modifications throughout its long and illustrious life. This timeless sneaker is a style staple, so if you can’t find a pair to match your own style, you just aren’t looking hard enough. You can shop a wide variety of color and material options for the legendary sneaker at Foot Locker now."
                     },

                     new ShoeBrand()
                     {
                         ShoeTypeId = 1,
                         ShoeBrandId = 2,
                         ShoeBrandName = "Adidas Harden Vol. 3",
                         BrandImagePath = "https://www.cnsmnt.com/wp-content/uploads/2018/11/adidas-harden-vol3-D96990_01_standard.jpg",
                         ShoeBrandInfo = "The Adidas Harden Vol. 3 is the next chapter in the James Harden story of on-court dominance. Coming in hot on the heels of the Houston Rockets star’s NBA MVP season, the Harden Vol. 3 is the third signature model for “The Bearded One,” designed to perform for his explosive and never-predictable game. Engineered to “Slow Down Fast,” the high-performance shoe is designed to help Harden stop on a dime and change speeds and directions as quickly as possible, leaving his opponents in the dust as he creates another opening to the rim for an electrifying finish. The shoe features a low-top cut constructed in a woven tech-mesh material for a lightweight, unrestrictive, and breathable feel, while a midfoot strap adds locked-down support for every move. Like Harden’s last two signature models, his third also features full-length Boost foam cushioning for a bouncy, energy-returning feel with every step for all-day comfort on the court. Just like James Harden’s commanding game and his fashion choices off the hardwood, the Harden Vol. 3 flaunts a disruptive style and never-follow attitude. The silhouette is one of the smoothest you’ll see on the court from the preps to the pros, but don't let the clean and sophisticated look fool you. The shoe is packed with all the best technology adidas has to offer to ensure great performance, stop-on-a-dime grip, and cloud-like cushioning to help you perform to your maximum potential. Foot Locker is your source for all the latest looks for the Harden Vol. 3 in a full range of sizes. Find your pair and hit the court."
                     },

                      new ShoeBrand()
                      {
                          ShoeTypeId = 1,
                          ShoeBrandId = 3,
                          ShoeBrandName = "Air Jordan 33",
                          BrandImagePath = "https://bouncewear.com/storage/14497/conversions/AQ8830-007-PHSRH000-big.jpg",
                          ShoeBrandInfo = "The Air Jordan 33 is the 33rd flagship Air Jordan model from Jordan Brand. Michael Jordan’s playing days may be long over, but his signature shoe is still at the top of the game. The Air Jordan 33 proves this once again with a revolutionary new design, featuring the debut of FastFit technology. FastFit is a first-of-its-kind laceless system that allows the wearer to get into, secure, and remove the shoe faster than traditional laced footwear. It works by utilizing a tightening system that is built with a series of cables that lock down the foot by simply pulling up on a strap found on the midfoot. To remove the shoe, the cables are loosened by pulling on the side loops. The FastFit system allows the wearer to be able to quickly loosen and tighten the shoe when resting and then re-entering game play. The Air Jordan 33 was designed by famed Jordan Brand basketball shoe designer Tate Keurbis, who paired the amazing new FastFit technology with inspiration from one of the most iconic Air Jordans of all time, the Air Jordan 3. Hints of the Jordan 3 are present in the overall look of the Jordan 33, namely the shape of the panel wrapping the heel, the tongue with a large Jumpman logo, and the “Nike Air” branding on the rear of each shoe. However, when it comes to performance, the Jordan 33 isn’t looking to the past for even one second. Along with the FastFit technology, the shoe also features a state of the art cushioning system, which utilizes Jordan brand’s Flight Speed technology. Flight Speed features a carbon fiber plate housed within the midsole to provide support and a springy, energy returning feel that pairs with Zoom Air for the most dynamic on-court cushioning on the market. Take flight in your own pair of the Air Jordan 33, available here at Foot Locker in a full range of men’s sizing and color options."
                      },

                       new ShoeBrand()
                       {
                           ShoeTypeId = 2,
                           ShoeBrandId = 4,
                           ShoeBrandName = "Nike Epic React Flyknit",
                           BrandImagePath = "https://stockx.imgix.net/Nike-Epic-React-Flyknit-Vast-Grey-Metallic-Gold-W.png?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1540948664",
                           ShoeBrandInfo = "The Nike Epic React Flyknit is at the forefront of Nike Running technology, featuring the brand’s new React Foam cushioning. The soft, energy-returning material offers all day comfort, whether you’re on run or wearing them casually. Already loved by core runners and casual sneaker wearers alike, React foam cushioning is featured in this sleek and sporty running shoe to make sure you look just as good as every step feels. The Epic React is constructed with a woven Flyknit upper that forms to the shape of your foot, giving you custom-adapted support and comfort in a lightweight and breathable material. Its foam outsole retains its shape and adds lightness to the shoe while rubber sections at the toe and heel provide traction and durability.The Nike Epic React Flyknit is available in a wide variety of colorways, from subdued to bright and colorful looks, ensuring everybody has a pair to match their style. The Epic React Flyknit makes running fun, thanks to its plush and snappy feel that pairs with the cutting-edge modern style and on-trend color options. Nike’s React foam is engineered to be extremely durable, resisting compression and keeping its shape to provide a brand-new feel even after 300 miles of use. Traditionally in white, the React foam midsole is also available in colored options on various styles. The Flyknit upper ranges from solid hues to multi-color options for each style."
                       },

                        new ShoeBrand()
                        {
                            ShoeTypeId = 2,
                            ShoeBrandId = 5,
                            ShoeBrandName = "ASICS Gel Kayano 25",
                            BrandImagePath = "https://cdn.sportsshoes.com/product/A/ASI8812/ASI8812_1000_1.jpg",
                            ShoeBrandInfo = "ASICS celebrates 25 years of their Kayano line with the release of the new GEL-Kayano 25. Over the course of a quarter century, ASICS has produced some of the most well-rounded running shoes on the market. The Japanese company was originally founded by Onitsuka Tiger head, Kihachiro Onitsuka, and officially became its own brand in 1977. Since then, ASICS has built a reputation as “the runner’s running shoe” with their wide range of models. There’s a pair of ASICS for every foot type, whether you over or under pronate, have wide feet, or overall foot pain problems. The magic lies in their trademark GEL cushioning technology that has been constantly refined through an evolution of updates and improvements over the years. Runners of all levels gravitate towards the ASICS GEL-Kayano line for its superior comfort and support. ASICS relies heavily on technology to deliver what runners expect in their footwear, and the GEL-Kayano 25 is the most technologically advanced shoe in their arsenal. Weight has been cut from the upper with the use of multi-layered engineered mesh. The benefit of multiple layers as opposed to a singular, thicker, layer of mesh is increased breathability without sacrificing the upper’s structural integrity. A molded TPU heel counter adds both stability, and overall foot lockdown, without adding any unnecessary extra weight. To further increase comfort, the shoe’s toe box is wider than comparable running shoes. The GEL-Kayano 25 utilizes an advanced dual-foam setup comprised of their signature FlyteFoam™ and FlyteFoam Propel™ technologies. Together the foams create a midsole that is both plush and responsive. The GEL-Kayano 25’s hallmark feature is glorious GEL. The heel features a visible GEL unit and the forefoot houses an internal GEL layer. Below the shoe’s remarkable midsole systems sits a bevy of tech. ASICS used a spine-like support feature called the Guidance Line Outsole™, which increases flexibility and runner efficiency. Alongside the Guidance Line Outsole™ rests the Guidance Trusstic System™ which counteracts torsion as the foot meets various surfaces. The bringing together of these technologies makes the ASICS GEL-Kayano 25 a fast and responsive running shoe."
                        },

                         new ShoeBrand()
                         {
                             ShoeTypeId = 2,
                             ShoeBrandId = 6,
                             ShoeBrandName = "Mizuno Wave Prophecy 7",
                             BrandImagePath = "https://cdn.sportsshoes.com/product/A/ASI8812/ASI8812_1000_1.jpg",
                             ShoeBrandInfo = "The Mizuno Wave Prophecy 7 offers comfort that makes every stride feel downright luxurious. Now on its seventh iteration, the Wave Prophecy continues to evolve with its innovative Infinity Wave cushioning platform that delivers shock absorption and energy return you can see. The Wave Prophecy 7 features a revised upper that is softer, lighter, and even more stylish than its predecessors. Constructed with Mizuno’s Air Mesh upper, this high-performance running shoe has superior breathability and a soft feel that’s broken in right out of the box. The intricate Dynamotion Fit design utilizes an exoskeleton that conforms and moves with your foot and works with the mesh upper for a second-skin feel. Below the Infinity Wave cushioning, the X10 carbon rubber outsole delivers extended durability for hundreds of miles on the road. The Wave Prophecy 7 offers high performance for every run with bold style to match. The futuristic design will have you feeling like you’re ready to take on any new goal, whether you’re looking to increase your training mileage or finish with a new PR in competition. Lace up a pair and hit the road today. You’ll be glad you did."
                         },

                          new ShoeBrand()
                          {
                              ShoeTypeId = 3,
                              ShoeBrandId = 7,
                              ShoeBrandName = "Reebok Workout Plus",
                              BrandImagePath = "https://images-na.ssl-images-amazon.com/images/I/51NJYNDLS2L._UL1000_.jpg",
                              ShoeBrandInfo = "Since its original release in 1987, the Reebok Workout Plus has never gone out of style. The trainer has earned a committed UK fan base that loves the shoe in a comparable way to the U.S. market’s love for Air Jordan retros. The timeless feel of Reebok Classics allows the Workout Plus to look fantastic in any decade on any continent. A shoe that was ahead of its time, the Workout Plus’s designers sought to create a shoe capable of holding up to the rigors of cross training. They aimed for the ability to go straight from the weight room to a tennis court. This multi-sport functionality was possible because of Reebok’s patented “H-Strap” mid-foot unit. The H-Strap allowed wearers to tighten the strap for improved lateral movement or loosen the strap for a more traditional running shoe feel. Reebok would continue to expand their cross-training line to include other classics like the Ventilator and Graphlite Pro. Currently, Reebok is the leader in cross-training footwear. Choosing to grow with the rise of multi-exercise competitions, Reebok began sponsoring various Crossfit competitions and acting as their exclusive outfitter. They’ve devoted an entire line exclusively to Crossfit with fantastic shoes like the Crossfit Nano 8 and the Crossfit Nano 2.0, which can be traced back to the Workout Plus. The Workout Plus is known for its ultra-premium, soft, full-grain leather and classic Reebok UK flag branding. There’s something inherently fresh about the design of this low-top OG trainer. Don’t be fooled though, the Workout Plus has plenty of substance, with an EVA foam midsole for shock absorption and added comfort. A sturdy, high-abrasion rubber outsole secures every step. In recent years, Reebok has remixed the Workout Plus for a new generation with collaborations with hot rappers like Lil Yachty and Lil Baby under their “Alter The Icons” initiative. The Alter The Icons line strives to promote individual uniqueness. Yachty said it best, “I’m not moved by others opinion because it doesn’t make who I am.” "
                          },

                           new ShoeBrand()
                           {
                               ShoeTypeId = 3,
                               ShoeBrandId = 8,
                               ShoeBrandName = "Adidas A.R. Trainer",
                               BrandImagePath = "https://cdn.shopify.com/s/files/1/0187/5180/products/ONENESS_0010_ADIDAS-DB2736_2000x.jpg?v=1550192701",
                               ShoeBrandInfo = "From deep in the adidas archives comes this vintage-inspired sneaker - the adidas A.R. Trainer. Complete with a muted silhouette and heavily influenced by the adidas classics, these are sure to please any old-school sneaker aficionado. The new design has reimagined the classic 1988 ASC Trainer, a throwback to the 1980s tennis sneakers, but it doesn’t stop there. The sneaker also features an ’80s-style multi-purpose sole unit and trefoil logo. In the 1980s these sneakers took the lead on grass, clay, and concrete and the upgraded versions take their cues from the 1988 classics. With a mix of textures, these streetwear shoes come with chunky accents and bright colors that echo the fashion trends of decades past."
                           },

                            new ShoeBrand()
                            {
                                ShoeTypeId = 3,
                                ShoeBrandId = 9,
                                ShoeBrandName = "Nike Air Max Speed Turf",
                                BrandImagePath = "https://stockx.imgix.net/Nike-Air-Max-Speed-Turf-Chlorophyll.png?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1538080256",
                                ShoeBrandInfo = "The Air Max Speed Turf is one of the most beloved cross-trainers Nike has ever released. First launched in 1995, the sneaker was designed as a football model for training or playing on astroturf, but was also utilized as an everyday trainer and even showed up on the basketball court. The tough-looking design features a mid-top height with aggressive lines and a large midfoot strap for locked-down support. Down below, an Air Max unit in the heel provides excellent cushioning, and a lugged waffle tread on the outsole keeps you from slipping on turf and grass surfaces. The Air Max Speed Turf is no stranger to bold branding like many Nike models of its era, with multiple logos found throughout the shoe that only increase its unforgettable appeal. Originally conceived as a performance model, the Air Max Speed Turf now has new life as a bold retro sneaker in Nike’s arsenal of classic designs. The shoe has returned in original colorways as well as on-trend looks in eye-catching color combinations. Find your perfect pair at Foot Locker today."
                            },

                            new ShoeBrand()
                            {
                                ShoeTypeId = 4,
                                ShoeBrandId = 10,
                                ShoeBrandName = "Puma Avid evoKNIT",
                                BrandImagePath = "https://www.kicksandice.com/media/catalog/product/cache/afad95d7734d2fa6d0a8ba78597182b7/t/m/tmp84253-2.jpg",
                                ShoeBrandInfo = "The PUMA Avid evoKNIT is at the forefront of sneaker technology with a design that blurs the lines between performance and fashion. The sleek and sporty silhouette combines a modern casual feel with performance technology from PUMA for a sneaker that’ll show your style is far more evolved than the rest of the crowd. With a speedy, running-inspired design, the Avid is constructed with a one-piece evoKNIT woven textile upper in a slip-on bootie style for a supportive, flexible, and breathable sock-like fit. The advanced properties of the shoe don’t end there, as the knit upper sits atop a full-length Ignite foam midsole, PUMA’s proprietary cushioning platform that provides a soft, energy-returning ride with comfort that lasts all day. The Ignite midsole is complemented by a flexible rubber outsole with a traction pattern that supplies multi-surface grip. The Avid evoKNIT is a multipurpose sneaker that’s perfect for your next session at the gym, or a stylish casual option for the streets. Either way, you can rest assured that it’s packed with PUMA’s latest technology for a supportive and well-cushioned performer. Ready to match anyone’s personal style, the Avid is available in a wide range of color combinations from solid hues to multicolor treatments, each just as memorable as the next. Evolve your sneaker style with the Avid evoKNIT."
                            },

                             new ShoeBrand()
                             {
                                 ShoeTypeId = 4,
                                 ShoeBrandId = 11,
                                 ShoeBrandName = "K-Swiss Classic VN",
                                 BrandImagePath = "https://shop.r10s.jp/kinetics-tokyo/cabinet/kswiss/6290-461-2.jpg",
                                 ShoeBrandInfo = "When you hear the name K-Swiss, the Classic VN is likely the sneaker that comes to mind. The clean and simple sneaker is the archetypal model from the iconic tennis shoe brand, as timeless as it is effortlessly stylish. Originally a performance model that dates back to the brand’s earliest days, it was the first-ever leather tennis shoe. Now the Classic VN has left the court to become one of the most beloved sneakers on the streets. It’s perfect for a laid-back casual look, but can also be dressed up for special occasions. The design features a low-top height built fully in leather, with the brand’s signature five stripes across the upper. The stripes extend up to double as lace loops for the D-ring metal eyelets. The Classic VN’s other defining feature is the three-piece toe design that splits down the middle of the foot. A sneaker that looks good enough to wear all day, every day has to be comfortable to be taken full advantage of, and the Classic VN certainly excels in that category. The soft leather upper is complemented with a plush EVA foam midsole, while the rubber outsole adds long-lasting durability. The D-ring lacing system also ensures a quick and easy lace-up when you put them on."
                             },

                             new ShoeBrand()
                             {
                                 ShoeTypeId = 4,
                                 ShoeBrandId = 12,
                                 ShoeBrandName = "Adidas Originals Stan Smith",
                                 BrandImagePath = "https://media.sssports.com/2000x2000/media/catalog/product/4/0/4054067760342_1_1.jpg",
                                 ShoeBrandInfo = "The adidas Originals Stan Smith is one of the most iconic sneakers of all time. The simple, stylish, and versatile design was originally a performance tennis shoe worn by professional star Stan Smith in the 1970s, and even though it still bears his name and portrait on the tongue, it is now worn by men, women, and kids across the globe. This essential sneaker takes advantage of its simplicity with an almost unlimited number of color and material combinations: from the iconic original white-and-green colorway to reptile-textured leather uppers, bold and bright color combinations, and graphic prints. The Stan Smith is as timeless as a sneaker gets. The clean, low-profile design never goes out of style and can be dressed up or down with anything from jeans, to athletic shorts, to a summer dress. A wide range of color options means that, no matter what your style, this essential sneaker matches it all. Find your perfect pair today."
                             });

            base.OnModelCreating(modelBuilder);
        }
    }
}
    
