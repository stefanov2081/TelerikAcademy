using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            // Get values from user unput.
            Console.WriteLine("Enter company name");
            string cmpName = Console.ReadLine();
            Console.WriteLine("Enter company address");
            string cmpAddress = Console.ReadLine();
            Console.WriteLine("Enter company phone number");
            string cmpPhnNum = Console.ReadLine();  // String, so that numbers like 1-800-call-now can be stored
            Console.WriteLine("Enter company fax number");
            string cmpFaxNum = Console.ReadLine();  // String, so that numbers like 1-800-call-now can be stored
            Console.WriteLine("Enter company web site");
            string cmpWebSite = Console.ReadLine();
            Console.WriteLine("Enter company manager's first name");
            string cmpMngrFrstName = Console.ReadLine();
            Console.WriteLine("Enter company manager's last name");
            string cmpMngLstName = Console.ReadLine();
            Console.WriteLine("Enter company manager's age");
            byte cmpMngAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter company manager's phone number");
            string cmpMngPhnNum = Console.ReadLine();

            // Print company info. 
            Console.WriteLine("\nCompany Information\n" + "Company name: " + cmpName + "\n" + "Company address: "               + cmpAddress + "\n" + "Company phone number: " + cmpPhnNum + "\n" + "Company fax number: " +                        cmpFaxNum + "\n" + "Company web site: " + cmpWebSite + "\n" + "...................\n" + 
                "Manager Information \n" + "Company manager's first name: " + cmpMngrFrstName + "\n" + 
                    "Company manager's last name: " + cmpMngLstName + "\n" + "Company manager's age: " + cmpMngAge                      + "\n" + "Company manager's phone number: " + cmpMngPhnNum + "\n" +
                        "...................");


        }
    }
}
