using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p_fileio_v01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\z.txt", FileMode.OpenOrCreate); //creating file stream

            f.WriteByte(65); //writing byte into stream

            f.Close(); //Closing stream
        }
    }
}
