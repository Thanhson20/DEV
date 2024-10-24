using Store;
namespace Lap07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tạo mới nhà phân khối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Coca Cola";
            dealer.Email = "cocacolap@gmail.com";
            dealer.Phone = "(111)791-8074";
            //In thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);
            //Tạo mới sản phẩm nằm trong nameSpace Store
            StoreItem si = new StoreItem();
            // gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta ";
            si.Price = 80.00M;

            //In thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #:     ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name:   ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price:   ");
            Console.WriteLine(si.Price);

            Console.Read();

        }
    }
}
