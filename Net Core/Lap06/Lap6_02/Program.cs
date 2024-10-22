namespace Lap6_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo sortedlist generic
            SortedList<string, string> listEm = new SortedList<string, string>();
            // Dưa dữ liệu vào 
            listEm.Add("E01", "Tran Thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            //in danh sách
            Console.WriteLine("Danh sach nhan vien");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
            //Tìm kiếm tên nhân viên bắt đầu bằng chữ Th

        }
    }
}
