using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTools.Extensions
{
    public static class IntegerExtensions
    {
        public static string ToHex(this int value)
        {
            return String.Format("0x{0:X}", value);
        }
    }
}
