using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LING01
{
    internal static class IntExtention
    {
        public static int Reserve(this int number)
        {
            int ReservedNumber = 0, LastDiget;
            while (number > 0)
            {
                LastDiget = number % 10;
                ReservedNumber = ReservedNumber * 10 + LastDiget;
                number /= 10;

            }
            return ReservedNumber;
        }
    }
}