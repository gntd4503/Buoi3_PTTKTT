using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int key = 72;
            int result = BinarySearchNonRecursive(arr, key);
            Console.WriteLine(result != -1 ? $"Tim thay key {key} tai vi tri {result}" : $"Khong tim thay key {key} trong mang");
            Console.ReadLine();
        }
        static int BinarySearchNonRecursive(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                    return mid;
                if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
