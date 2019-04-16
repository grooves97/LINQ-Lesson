using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class StringExtention
    {
        public static int GetCount(this string data)
        {
            return data.Length;
        }
    }
}
