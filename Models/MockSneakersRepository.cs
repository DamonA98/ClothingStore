namespace ClothingStore.Models
{
    public class MockSneakersRepository : ISneakersRepository
    {
        private ICategoryRepository _categoryRepository = new  
            MockCategoryRepository();

        public IEnumerable<Sneakers> AllSneakers =>
            new List<Sneakers>
            {
                new Sneakers{SneakersId = 1, Name = "Jordan 3 Cardinal", Category = _categoryRepository.AllCategories.ToList()[0], Color = "Red", Price = 200, Quantity = 3, Size = 12
                , ImageThumbnailURL = "https://m.media-amazon.com/images/W/WEBP_402378-T2/images/I/61wnA+dtUML._AC_UX695_.jpg"
                , ImageUrl = "https://cdn.sanity.io/images/c1chvb1i/production/ed43f578778f6dfff07beccef245e79b8d0dba24-1100x772.jpg/Air-Jordan-3-Cardinal-2022-Release-Date.jpeg"
                , Sku = "CT8532-126", IsSneakersofTheWeek = false, Description = "The Air Jordan 3 Retro ‘Cardinal Red’ showcases a distinctive palette influenced by an OG colorway" +
                    " of the Air Jordan 7. The sneaker’s titular hue appears on the collar lining, molded eyelets, and raised Jumpman branding at the heel, all of which are contrasted" +
                    " by a white tumbled leather upper."},

                 new Sneakers{SneakersId = 2, Name = "Jordan 4 Lightning", Category = _categoryRepository.AllCategories.ToList()[0], Color = "Yellow", Price = 200, Quantity = 2, Size = 10
                , ImageThumbnailURL = "https://th.bing.com/th/id/OIP.Tz6koVv-aK4IY0sZVMIoWAHaEb?w=297&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7"
                , ImageUrl = "https://sneakernews.com/wp-content/uploads/2021/04/air-jordan-4-lightning-CT8527-700-release-date-8.jpg?w=1140"
                , Sku = "CT8527-700", IsSneakersofTheWeek = false,Description ="Originally released in 2006, the Air Jordan 4 Retro Lightning (2021) is one of the most renowned retro" +
                     " Jordan 4 colorways in Jordan Brand's catalog. It features a Tour Yellow Durabuck upper with black netted panels and dark grey eyelets. On the tongue, a black Jordan" +
                     " Flight logo patch with white and yellow accents complements the upper."},

                 new Sneakers{SneakersId = 3, Name = "Jordan 1 Bred Toe", Category = _categoryRepository.AllCategories.ToList()[0], Color = "Red", Price = 170, Quantity = 1, Size = 11
                , ImageThumbnailURL = "https://i.pinimg.com/originals/e7/b2/b2/e7b2b2192b60276ac76ea051f037e006.jpg"
                , ImageUrl = "https://th.bing.com/th/id/R.ac8d5f0381867f9d34b502eb2e0cf180?rik=UGb0rteYUYa8GA&pid=ImgRaw&r=0"
                , Sku = "5088-610", IsSneakersofTheWeek = false,Description ="Combining elements of three certified classic AJ1’s, the 2018 Jordan 1 Retro High Bred Toe is like" +
                     " the Coachella lineup of OG 1s. Coming in gym red, black, and summit white, with red on the toe box, outsole, and wrapping around the ankle and heel, white side" +
                     " panels and midsole and black covering the rest of the sneaker, it’s a perfectly balanced mash-up of the Banned, Chicago, and Black Toe all in one. Originally" +
                     " releasing in February of 2018"},

                  new Sneakers{SneakersId = 4, Name = "Yeezy 700 Sun", Category = _categoryRepository.AllCategories.ToList()[2], Color = "Grey", Price = 260, Quantity = 3, Size = 12
                , ImageThumbnailURL = "https://th.bing.com/th/id/OIP.azkW5mhF84X5nkd4gk7P_wHaFM?pid=ImgDet&rs=1"
                , ImageUrl = "https://th.bing.com/th/id/R.31bf54a5b1f0a2f1b436e2153df3ce9d?rik=66tEUQxty7pn3w&pid=ImgRaw&r=0"
                , Sku = "GZ6984", IsSneakersofTheWeek = true,Description ="The adidas Yeezy Boost 700 Sun is primarily composed of a bright yellow mesh, leather, and suede upper with back and" +
                      " teal overlays located over the forefoot. 3M detailing on the heel, a bright orange Boost midsole, and a dark grey outsole adds the finishing touches to this vibrant design."},

                   new Sneakers{SneakersId = 4, Name = "Yeezy 500 Granite", Category = _categoryRepository.AllCategories.ToList()[2], Color = "Grey", Price = 210, Quantity = 4, Size = 10
                , ImageThumbnailURL = "https://m.media-amazon.com/images/W/WEBP_402378-T2/images/I/71yJGgoGqOL._AC_UX695_.jpg"
                , ImageUrl = "https://i.ebayimg.com/images/g/YSQAAOSwLRBi~7RO/s-l500.jpg"
                , Sku = "GW6373", IsSneakersofTheWeek = false,Description ="Composed of tonal grey mesh, suede, and leather, the adidas Yeezy 500 Granite offers a monochromatic styling" +
                       " similar to the early Yeezy 500s of 2018. Woven lace loops on the tongue nod to the tooling of 1990s hiking boots. From there, a sculptural sole with adiPrene" +
                       " cushioning provides comfort and support."},

                     new Sneakers{SneakersId = 5, Name = "Nike Dunk Dodgers", Category = _categoryRepository.AllCategories.ToList()[2], Color = "Blue", Price = 110, Quantity = 2, Size = 9
                , ImageThumbnailURL = "https://i.ebayimg.com/images/g/qVkAAOSwBDBi1us3/s-l500.jpg"
                , ImageUrl = "https://cdn.shopify.com/s/files/1/0630/3898/0336/products/image_bb0f5edc-0085-4b6f-a7ee-13b934331e41_1445x.png?v=1659363771"
                , Sku = "DO9395-400", IsSneakersofTheWeek = true,Description ="The Nike SB Dunk Low Los Angeles Dodgers features a white leather upper with blue overlays and red Swoosh logos." +
                         " The Nike brand name is prevanlent on the heel tab in red. The Nike SB Dunk Low Los Angeles Dodgers is a low-top sneaker with lace-up closure style. The shoe features" +
                         " a blue and white color scheme that has shades similar to the traditional blue and white worn by the MLBs LA Dodgers. It has a light-brown sole with a pink graphic on" +
                         " the ankle’s right side." },

                       new Sneakers{SneakersId = 6, Name = "Nike Sacai Vapor waffle Sail ", Category = _categoryRepository.AllCategories.ToList()[1], Color = "White", Price = 180, Quantity = 3, Size = 10
                , ImageThumbnailURL = "https://th.bing.com/th/id/OIP.gc0Y_jMcT7fOrqcMtJVfWwHaFS?pid=ImgDet&rs=1"
                , ImageUrl = "https://th.bing.com/th/id/OIP.rC6t2K-iirhUzBpaWdwfHAHaEo?pid=ImgDet&rs=1"
                , Sku = "DD1875-100", IsSneakersofTheWeek = true, Description ="The Nike Vaporwaffle sacai Sail Gum features a Sail nylon upper with light grey suede overlays and tumbled leather" +
                           " Swooshes. Doubled tongues and Swooshes continue sacai's design ethos of reconstruction. At the base, a stacked foam midsole atop a gum outsole completes the design." },

                        new Sneakers{SneakersId = 7, Name = "Yeezy Foam Runner Onyx ", Category = _categoryRepository.AllCategories.ToList()[2], Color = "Black", Price = 90, Quantity = 7, Size = 10
                , ImageThumbnailURL = "https://i.ebayimg.com/images/g/FqwAAOSwmiJi1NbC/s-l500.jpg"
                , ImageUrl = "https://img.ricardostatic.ch/t_1000x750/pl/1207933792/1/1/adidas-yeezy-foam-runner-onyx-eu-405.jpg"
                , Sku = "HP8739", IsSneakersofTheWeek = false, Description ="The adidas Yeezy Foam RNR Onyx arrives with an Onyx, oval-cut foam construction made of part EVA and algae. At the base, a cushioned footbed offers comfort" +
                            " and support, while a sculptural sole with deep treads provides traction." }



            };
        public IEnumerable<Sneakers> IsSneakersofTheWeek
        {
            get { return AllSneakers.Where(p => p.IsSneakersofTheWeek); }
        }

        public Sneakers? GetSneakersById(int SneakersId) => AllSneakers.FirstOrDefault(p => p.SneakersId == SneakersId);

        public IEnumerable<Sneakers> SearchSneakers(string searchQuery)
        {
            throw new NotImplementedException();
        }
        
           
       
    }
}
