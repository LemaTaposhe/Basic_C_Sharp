using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Random random = new Random();
            //Console.WriteLine(random.Next());
            RNGCryptoServiceProvider rNG = new RNGCryptoServiceProvider();
            byte[] myBytes = new byte[54215];
            rNG.GetBytes(myBytes);
            foreach (byte b in myBytes)
            {
                Console.WriteLine("{0} ", b);
            }
        }
    }
}
