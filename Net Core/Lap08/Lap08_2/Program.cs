namespace Lap08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo Customer
            var customer = new Customer[]
            {
                new Customer {Id = 5, Name = "Sam" },
                new Customer {Id = 6, Name = "Dave" },
                new Customer {Id = 7, Name = "Julia" },
                new Customer {Id = 8, Name = "Sue" },

            };
            //Khởi tạo Order
            var orders = new Order[]
            {
                new Order {Id = 5, Product = "Book" },
                new Order {Id = 6, Product = "Game" },
                new Order {Id = 7, Product = "Computer" },
                new Order {Id = 8, Product = "Shirt" },
            };
            //Sử dụng truy vấn và join 2 tập dữ liệu dự trên ID
            var query = from c in customer join o in orders on c.Id equals o.Id
            select new { c.Name, o.Product };
            //Hiện thị tên khách hàng và nhóm sản phẩm
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);

            } 
                
        }
    }
}
