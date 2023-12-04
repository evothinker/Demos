using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoops
{
    public static class Validator
    {
        private static int num = 0;
        public static bool IsIntegerGreaterThanZero(string value)
        {
            if (!int.TryParse(value, out num))
            {
                return false;
            }

            if (num < 1)
            {
                return false;
            }
            
            return true;
        }

        public static bool IsDecimal(string value)
        {
            return true;
        }
    }
}
