using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public delegate bool ConditionFuncDelegate(int x);
    public delegate bool ConditionFuncDelegateString(string x);
    public delegate bool ConditionFuncDelegateT<T>(T x);
    internal class ConditionsFunctions
    {
        public static bool CheckOdd(int x) { return x % 2 != 0; }
        public static bool CheckEven(int x) {return x % 2 == 0; }
        public static bool CheckDivisableByFour(int x) { return x % 4 == 0; }
        public static bool CheckStringLengthGreaterThanFive(string str) { return str.Length > 5; }
    }
}
