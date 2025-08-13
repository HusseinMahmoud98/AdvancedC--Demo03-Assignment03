using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    internal static class SortingConditions
    {
        public static bool CompareGtr(int x, int y) { return x > y; }
        public static bool CompareLess(int x, int y) {return x < y; }
        public static bool CompareGtr(string x, string y) { return x.Length > y.Length; }
        public static bool CompareLess(string x, string y) { return x.Length < y.Length; }

    }
}
