using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 3, 8, 5, 2, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Mang sau khi sap xep QuickSort:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
