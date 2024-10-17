using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04
{
    internal class Window
    {
        //Khai báo các trường 
        protected int top;
        protected int left;
        //Phương thức khởi tạo
        public Window (int top, int left)
        {
            this.top = top; 
            this.left = left;
        }
        //phương thức virtual vẽ cửa sổ 
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",top,left);
        }
    }
}
