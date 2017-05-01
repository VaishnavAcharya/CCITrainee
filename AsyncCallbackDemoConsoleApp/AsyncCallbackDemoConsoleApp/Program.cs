using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCallbackDemoConsoleApp
{
    class Program
    {
        public delegate DataTable DelegateMethod(string str);
        public static DataTable dt;
        public static DelegateMethod dmethod;
        static void Main(string[] args)
        {
            dmethod = new DelegateMethod(Print);
            dmethod.BeginInvoke("Vaishnav", new AsyncCallback(Callback), null);
            Console.ReadKey();
        }

        private static void Callback(IAsyncResult ar)
        {
            dt = dmethod.EndInvoke(ar);

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine(row["Age"].ToString());
            }
        }

        private static DataTable Print(string str)
        {
            Thread.Sleep(4000);
           // Console.WriteLine(str);
            DataTable dt = new DataTable();
            dt.Columns.Add("Age");
            dt.Rows.Add("Age");
            dt.Rows.Add(11);
            dt.Rows.Add(20);
            dt.Columns.Add("Name");
            dt.Rows.Add("Name");
            dt.Rows.Add(str);
            return dt;
        }
    }
}
