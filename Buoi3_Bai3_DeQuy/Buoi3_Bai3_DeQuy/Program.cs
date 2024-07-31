using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Bai3_DeQuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int key = 28;
            int result = BinarySearchRecursive(arr, key, 0, arr.Length - 1);
            Console.WriteLine(result != -1 ? $"Tim thay key {key} tai vi tri {result}" : $"Khong tim thay key {key} trong mang");
            Console.ReadLine();
        }

        static int BinarySearchRecursive(int[] arr, int key, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;
            if (arr[mid] == key)
                return mid;

            if (arr[mid] > key)
                return BinarySearchRecursive(arr, key, left, mid - 1);
            else
                return BinarySearchRecursive(arr, key, mid + 1, right);
        }
    }
}
