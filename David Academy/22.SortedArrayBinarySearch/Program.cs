using System;
using System.Collections.Generic;

namespace _22.SortedArrayBinarySearch
{
    class Program
    {

        static void Sorted(int[] a, int n)
        {
            List<int> binary = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (binary.Count == 0)
                    binary.Add(a[i]);
                else
                {
                    int start = 0, end = binary.Count - 1;

                    int pos = 0;

                    while (start <= end)
                    {
                        int mid = start + (end - start) / 2;
                        if (binary[mid] == a[i])
                        {
                            binary.Insert((Math.Max(0, mid + 1)), a[i]);
                            break;
                        }
                        else if (binary[mid] > a[i])
                        {
                            pos = end = mid - 1;
                        }
                        else
                            pos = start = mid + 1;


                        if (start > end)
                        {
                            pos = start;
                            binary.Insert(Math.Max(0, pos), a[i]);
                            break;
                        }
                    }
                }
                for (int j = 0; j < n; i++)
                    Console.Write(binary[i] + " ");
            }


            static void Main(string[] args)
            {
                int[] a = { 4, 8, 9, 2, 6, 7, 9 };
                int n = a.Length;

                Sorted(a, n);
            }
        }
    }
     
    
}
