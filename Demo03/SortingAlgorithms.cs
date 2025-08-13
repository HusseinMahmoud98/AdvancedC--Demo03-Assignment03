using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public delegate bool SortingFancDelegate(int A, int B);
    public delegate bool SortingFancDelegateString(string A, string B);
    public delegate bool SortingFancDelegateT<T>(T A, T B);

    internal static class SortingAlgorithms
    {
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static void SwapString(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

        private static void SwapString<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort(int[] Arr, SortingFancDelegate reference)
        {
            if (Arr?.Length > 0)
            {
                for (int  i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j+1]))
                        {
                            Swap(ref Arr[j], ref Arr[j+1]);
                        }

                    }

                }

            }
            
        }

        public static void BubbleSort(String[] Arr, SortingFancDelegateString reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            SwapString(ref Arr[j], ref Arr[j + 1]);
                        }

                    }

                }

            }

        }

        public static void BubbleSortT<T>(T[] Arr, SortingFancDelegateT<T> reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            SwapString(ref Arr[j], ref Arr[j + 1]);
                        }

                    }

                }

            }

        }

        public static void BubbleSortAscending(int[] Arr)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j] > Arr[j+1]) //Swap
                        {
                            Swap(ref Arr[j], ref Arr[j+1]);
                        }
                    }
                }
            }
        }

        public static void BubbleSortDescending(int[] Arr)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j] < Arr[j + 1]) //Swap
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }
    }
}
