using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04_03
{
    internal interface IStoreable
    {
        string Data { get; set; }
        void Write(string fileName);
        void Read(string fileName);
    }
}
