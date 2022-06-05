
//testing
//inventooory
namespace InventoryService
{

    public class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }


    }

    public class Item
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Inventory
    {

        public int Id { get; set; }

        public List<Item> Items { get; set; } = new List<Item>{
            new Item(){
                Product = new Product(){Id = 1 , Name = "PlayStation 5 Console" , Image = "https://m.media-amazon.com/images/I/619BkvKW35L._AC_UL320_.jpg" , Price=700},
                Quantity = 100
                },
            new Item(){
                Product = new Product(){Id = 2 , Name = "Meta Quest 2 Virtual Reality Headset" , Image = "https://m.media-amazon.com/images/I/61tE7IcuLmL._AC_UL320_.jpg" , Price=399},
                Quantity = 1000
                },
            new Item(){
                Product = new Product(){Id = 3 , Name = "Xbox Series S" , Image = "https://m.media-amazon.com/images/I/71NBQ2a52CL._AC_UL320_.jpg" , Price=255},
                Quantity = 99
                },
            new Item(){
                Product = new Product(){Id = 4 , Name = "PlayStation DualSense Wireless" , Image = "https://m.media-amazon.com/images/I/61Uh8NFDzsL._AC_UL320_.jpg" , Price=22},
                Quantity = 100
                },
            new Item(){
                Product = new Product(){Id = 5 , Name = "DualShock 4 Wireless" , Image = "https://m.media-amazon.com/images/I/61IG46p-yHL._AC_UL320_.jpg" , Price=100},
                Quantity = 99
                },
            new Item(){
                Product = new Product(){Id = 6 , Name = "Logitech G502 HERO High Performance" , Image = "https://m.media-amazon.com/images/I/61mpMH5TzkL._AC_UY218_.jpg" , Price=10},
                Quantity = 100
                },
            new Item(){
                Product = new Product(){Id = 7 , Name = "BENGOO G9000 Stereo Gaming Headset" , Image = "https://m.media-amazon.com/images/I/61CGHv6kmWL._AC_UY218_.jpg" , Price=290},
                Quantity = 100
                },
        };

    }


}