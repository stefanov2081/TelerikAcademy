using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _03Enigmation
{
    class Program
    {
        public static decimal Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return decimal.Parse((string)row["expression"]);
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.Remove(input.Length - 1);
            decimal sum = Evaluate(input);
            Console.WriteLine("{0:f3}", sum);
        }

        
    }
}
