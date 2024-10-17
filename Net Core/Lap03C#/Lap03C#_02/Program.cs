namespace Lap03C__02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng constact với constructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Nguyen Thi";
            ct1.Lastname = "Hoa";
            ct1.Address = "Ha noi";
            ct1.Phone = "0988765429";
            ct1.Email = "hoahoa@gmail.com";
            //tạo đối tượng contact với constractor có tham số 
            Contact ct2 = new Contact(5, "Tran Thi", "Tinh", "Tuyen Quang", "0976542883", "bupbecotinhyeu@yahoo.com");
            //hiển thi thông tin ct1 vt2
            ct1.Display();
            ct2.Display();
        }
    }
}
