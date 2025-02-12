﻿using System;

namespace HelloGeneric
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 2, 3, 4, 5, 6 };
            double[] a3 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] a4 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            var result = Zip(a1, a2);
            var result2 = Zip(a3, a4); // 直接run會報錯，新增double[]雖然能運行，但又會發生(方法)成員膨脹
            System.Console.WriteLine(string.Join(", ", result));
            System.Console.WriteLine(string.Join(", ", result2));
        }

        // static int[] Zip(int[] a, int[] b) // a or b not null
        // {
        //     int[] zipped = new int[a.Length + b.Length];
        //     int ai = 0, bi = 0, zi = 0;
        //     do
        //     {
        //         if (ai < a.Length)
        //         {
        //             zipped[zi++] = a[ai++];
        //         }
        //         if (bi < b.Length)
        //         {
        //             zipped[zi++] = b[bi++];
        //         }
        //     } while (ai < a.Length || bi < b.Length);

        //     return zipped;
        // }

        // static double[] Zip(double[] a, double[] b) // a or b not null
        // {
        //     double[] zipped = new double[a.Length + b.Length];
        //     int ai = 0, bi = 0, zi = 0;
        //     do
        //     {
        //         if (ai < a.Length)
        //         {
        //             zipped[zi++] = a[ai++];
        //         }
        //         if (bi < b.Length)
        //         {
        //             zipped[zi++] = b[bi++];
        //         }
        //     } while (ai < a.Length || bi < b.Length);

        //     return zipped;
        // }

        // 解法: 把類型參數加在方法名後面，改成泛型方法
        static T[] Zip<T>(T[] a, T[] b) // a or b not null
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length)
                {
                    zipped[zi++] = a[ai++];
                }
                if (bi < b.Length)
                {
                    zipped[zi++] = b[bi++];
                }
            } while (ai < a.Length || bi < b.Length);

            return zipped;
        }
    }
}