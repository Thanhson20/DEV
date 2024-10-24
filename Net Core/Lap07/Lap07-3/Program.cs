namespace Lap07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xuất unicode 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //khai báo mảng 
            byte[] a = new byte[5];
            //nhập mảng 
            try
            {
                for (int i = 0; i <=5; i++)
                {
                    Console.Write("a[{0}]", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());

                } 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Không được nhập kí tự cho mảng số");
            }
        }
    }
}
