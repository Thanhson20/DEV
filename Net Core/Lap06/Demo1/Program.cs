using System.Collections;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Khởi tạo
            ArrayList arrayList = new ArrayList();
            // thêm các phần tử
            // Add
            arrayList.Add(111);
            arrayList.Add("ThanhSon");

            //Add Range
            string[] strs = { "Tùng", "Cúc", "Trúc", "Mai" };
            arrayList.AddRange(strs);

            //In mảng
            printArray(arrayList);

            //Insert
            arrayList.Insert(0, "Devmaster");
            printArray(arrayList);

            static void printArray(ArrayList arrayList)
            {
                Console.WriteLine("Danh sach cac phan tu");
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }





            }
        }
    }
}

