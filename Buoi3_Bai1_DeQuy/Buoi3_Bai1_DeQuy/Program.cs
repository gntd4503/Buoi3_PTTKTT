using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Bai1_DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int sum = SumArrayRecursive(arr, 0, arr.Length - 1);
            Console.WriteLine("Tong cua mang la: " + sum);
            Console.ReadLine();
        }
        static int SumArrayRecursive(int[] arr, int left, int right)
        {
            if (left == right)
                return arr[left];

            int mid = (left + right) / 2;
            int leftSum = SumArrayRecursive(arr, left, mid);
            int rightSum = SumArrayRecursive(arr, mid + 1, right);
            return leftSum + rightSum;
        }
    }
}
