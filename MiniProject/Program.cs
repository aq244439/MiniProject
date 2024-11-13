using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to\n###############################\n# B O B ' S   H O M E W O R K #\n###############################\n");
            string sel = "h";
            while (sel != "1" && sel != "2" && sel != "3" && sel != "4")
            {
                Console.WriteLine("Please select one of the following\n1-Show Homework\n2-Add Homework\n3-Mark Homework Complete\n4-Exit");
                sel = Console.ReadLine();
                switch (sel)
                {
                    case "1": 
                        showHomework(); 
                        break;
                    case "2":
                        addHomework();
                        break;
                    case "3":
                        markHomework();
                        break;
                    case "4":
                        exit();
                }
            }
        }
        static void showHomework()
        {

        }
    }
}
