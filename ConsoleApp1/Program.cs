using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvRandom
{
    // Test
    class Program
    {
        private static UdvidetRandom r = new UdvidetRandom();

        static void Main(string[] args)
        {      
            Console.WriteLine(r.NextBool());
            
        }

    }

    class UdvidetRandom : Random
    {
        public (bool,int) NextBool()
        {
            int number = 0;
            bool result = false;

            number = this.Next(1, 1002);

            if (number < 500) result = true;
            else result = false;



            return (result,number);
        }


    }
}
