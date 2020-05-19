using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlManager manager = new SqlManager(new MySql());
            manager.Add();

            Console.ReadKey();
        }
    }

    class SqlServer:ISqlManager
    {
        public void Delete()
        {
            Console.WriteLine("SqlServer Delete");
        }

        public void Insert()
        {
            Console.WriteLine("SqlServer Insert");
        }
    }

    class MySql:ISqlManager
    {
        public void Delete()
        {
            Console.WriteLine("MySql Delete");
        }

        public void Insert()
        {
            Console.WriteLine("MySql Insert");
        }
    }
    interface ISqlManager
    {
        void Delete();
        void Insert();
    }

    class SqlManager
    {
        private ISqlManager _sqlmanager;

        public SqlManager(ISqlManager sqlmanager)
        {
            _sqlmanager = sqlmanager;
        }

        public void Add()
        {
            _sqlmanager.Delete();
            _sqlmanager.Insert();
        }
    }

}
