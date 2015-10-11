using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryCount
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string toContinue = "";
            do
            {
                string userValue = getUserInput();
                bool res = isBinary(userValue);
                Console.WriteLine("You entered :{0}\nBoolean number:{1}", userValue, res.ToString());
                Console.WriteLine(countBinary(res, userValue));
                Console.WriteLine("Do you want to try again? (Y/N):");
                toContinue = Console.ReadLine();
            }while(toContinue == "Y" | toContinue == "y");
        }


        private static string getUserInput()
        {
            Console.WriteLine("Please enter a binary number:");
            return (Console.ReadLine());
        }


        private static bool isBinary(string userValue)
        {
            foreach (var c in userValue)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }


        private static string countBinary(bool status,string userValue)
        {
            int count = 0;
            if(status==true)
            {
                foreach (var c in userValue)
                {
                    if (c == '0')
                    {
                        count += 1;
                    }
                }
                return "Size of Number: " + userValue.Length + "\nNumber of zero's: " + count.ToString() + "\nNumber of One's: " + (userValue.Length-count);
            }
            else
            {
                return "Please enter a binary number";
            }
        }

    }
}
