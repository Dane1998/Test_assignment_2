using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2_test
{
    public class Converters
    {
        
        public static void Main()
        {
            
        }


        public static string Uppercase(string anyString)
        {
            string z = "";
            char c;
            int i, n;

            for (i = 0; i < anyString.Length; i++)
            {
                c = anyString[i];
                if (c >= 97 && c <= 122)
                {
                    n = c - 32;
                    c = (char)n;
                }

                z += c;
            }

            return z;
        }

        public static string Lowercase(string anyString)
        {
            string z = "";
            char c;
            int i, n;

            for (i = 0; i < anyString.Length; i++)
            {
                c = anyString[i];
                if (c >= 97 && c <= 122)
                {
                    n = c - 32;
                    c = (char)n;
                }

                z += c;
            }

            return z;
        }


        public static string Reverse(string anyString)
        {
            string result = "";

            for (int i = anyString.Length - 1; i >= 0; i--)
            {
                result += anyString[i];
            }
            return result;
        }
         

    }
}
