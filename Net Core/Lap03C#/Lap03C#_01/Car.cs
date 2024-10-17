using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap03C__01
{
    internal class Car
    {
        //Khai báo các trường với vi phạm public
        public string make;
        public string model;
        public string color;
        public int year;
        //định nghĩa phương thức start
        public void Start()
        {
            System.Console.WriteLine(model + " khoi dong");
        }
        // định nghĩa phương thức stop
        public void Stop()
        {
            System.Console.WriteLine(model + " dung");
        }
    }
}
