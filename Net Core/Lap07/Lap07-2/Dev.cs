using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tạo namespace kinh doanh
namespace Bussiness

{
    //lớp nhà ở
    internal class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }
    //tạo namespace con đại lý tổng bên trong namespace kinh doanh
    namespace Dealership
    {
        //tạo lớp xe
        public class Car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; }
        }
    }
}
