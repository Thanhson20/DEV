
using Lap08_3;

class Program
{
    static void Main(string[] args)
    {

        //Khai báo chung 
        int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1, };
        string[] Words = {
                "Chi", "trich", "phe", "phan", "nguoi", "khac", "giong", "nhu", "con", "chim", "bo", "cau", "dua", "thu", "bao", "gio", "cung", "quay", "ve", "noi", "xuat", "phat"
            };
        List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId="F01", FilmName= "Điệp viên 007", Price=120000},
                new Film{FilmId="F02", FilmName= "Tam Quốc Diễn Nghĩa", Price=130000},
                new Film{FilmId="F03", FilmName= "Thiếu lâm truyền kỳ", Price=160000},
                new Film{FilmId="F04", FilmName= "Người nhện 2", Price=100000},
                new Film{FilmId="F05", FilmName= "Ngân hàng tình yêu ", Price=340000},
                new Film{FilmId="F06", FilmName= "Người đẹp và quái thú", Price=230000},
                new Film{FilmId="F07", FilmName= "Biệt động Sài Gòn", Price=190000},
            };
        //lọc các số chắn 
        IEnumerable<int> querynumber = Numbers.Where((n => n % 2 == 0);
        Show<int>(querynumber, "Loc cac so chan: ");
        //lọc các từ có độ dài  >4
        IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
        Show<string>(queryword, "Loc cac tu co do dai >4:");
        //lọc các từ có tên bắt đầu bằng chữ t
        IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
        Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t:");
        //Lọc các số duy nhất trong các tập số

    }

    static void Show<T>(IEnumerable<T> data, string messager)
    {
        Console.WriteLine(messager);
        foreach (var item in data)
        {
            Console.WriteLine(item);  
        }

    }   
}

