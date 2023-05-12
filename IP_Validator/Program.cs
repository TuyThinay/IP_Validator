using System;
using System.Text.RegularExpressions;

namespace IP_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ip:");
            string ip = Console.ReadLine();
            bool isValid = IsValidIPv4(ip);
            Console.WriteLine($"Is {ip} a valid IPv4 address? {isValid}");
        }

        static bool IsValidIPv4(string ip)
        {
            string substr1 = ip.Substring(0, 1);
            if(substr1 == "0")
            {
                return false;
            }

            string[] octets = ip.Split('.');


            if (octets.Length != 4)
            {
                return false;
            }
            


            foreach (string octet in octets)
            {
                Console.Write(octet[0]);
                if (!int.TryParse(octet, out int num) || num < 0 || num > 255 || (octet.Length > 1 && octet[0] == '0'))
                {
                    return false;
                }
            }

            return true;
        }


    }
}
