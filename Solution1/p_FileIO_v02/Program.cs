using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p_FileIO_v02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\output.txt", FileMode.OpenOrCreate);

            //StreamWriter s= new StreamWriter(f);
            //s.WriteLine("Hello_World");
            //s.WriteLine("How are you?");
            StreamReader s = new StreamReader(f);
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
            s.Close();
            f.Close();
           // Console.WriteLine("File created Succesfully...");



        }
    }
}
