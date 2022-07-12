using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoReflection
{
     class Program
    {
        static void Main(string[] args)
        {
            //Load  entire metadata i.e. Assembly object from DLL File 
            Assembly assembly = Assembly.LoadFrom(@"C:\Z Programing Languages\Dot net\Solution1\Calculator\bin\Debug\Calculator.dll");
           
            //In this line We are asking assembly object to get us all diff class 
            //and types  info maintained... since  there can be many... it gives us array

            Type[]allTypes = assembly.GetTypes();

            {
                for(int i = 0; i < allTypes.Length; i++)
                {
                    Type type = allTypes[i]; //  refer one type at a time

                    MethodInfo[] allMethodInfo  =  type.GetMethods();

                    for(int j = 0; j < allMethodInfo.Length; j++)
                    {
                        MethodInfo method = allMethodInfo[j];   //refer one method at a time

                        Console.WriteLine("--" + method.Name);
                    }
                }

            }
            Console.ReadLine();
            

        }
    }
}
