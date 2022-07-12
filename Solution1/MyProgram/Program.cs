using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us What you want: ");
            Console.WriteLine("1: SQLServer, 2: Oracle, 3: MySQL ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            DatabaseFactory dbFactory = new DatabaseFactory();
            IDatabase somObject = dbFactory.GetSomeDatabase(choice);

            Console.WriteLine("Select choice: ");
            Console.WriteLine("1: Insert, 2: Update, 3:Delete ");
            int opchoice = Convert.ToInt32(Console.ReadLine());

            switch (opchoice)
            {
                case 1:
                    somObject.Insert();
                    break;
                case 2:
                    somObject.Update();
                    break;
                case 3:
                    somObject.Delete();
                    break;
                    default:
                    Console.WriteLine("Invalid choice ");
                    break;

            }
            Console.ReadLine();


        }
    }

    public class DatabaseFactory
    {
        public IDatabase GetSomeDatabase(int choice)
        {
            IDatabase somobj = null;

            if(choice == 1)
            {
                somobj = new SQLServer();
            }
            if (choice == 2)
            {
                somobj = new Oracle();
            }
            else
            {
                somobj = new MYSQL();
            }
            return somobj;
        }
    }

    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class SQLServer : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("SQLServer DELETE");
        }

        public void Insert()
        {
            Console.WriteLine("SQLServer ISDERT");
        }

        public void Update()
        {
            Console.WriteLine("SQLServer UPDATE");
        }
    }

    public class MYSQL : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("MySQL DELETE");
        }

        public void Insert()
        {
            Console.WriteLine("MySQL ISDERT");
        }

        public void Update()
        {
            Console.WriteLine("MySQL UPDATE");
        }
    }

    public class Oracle : IDatabase
    {
        public void Delete()
        {
            Console.WriteLine("Oracle DELETE");
        }

        public void Insert()
        {
            Console.WriteLine("Oracle ISDERT");
        }

        public void Update()
        {
            Console.WriteLine("Oracle UPDATE");
        }
    }

}

