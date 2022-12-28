using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
internal static class ExtentionCheck
{
    public static void IsGeaterThan(this int i, int value)
    {
        if (i > value) {
            Console.WriteLine($"{i} lớn hơn {value} ");
        }
    }


}
