using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            // MergeSort
            int[] mergeSortedArray = (int[])array.Clone();
            MergeSort.Sort(mergeSortedArray);
            Console.WriteLine("Merge Sorted array:");
            PrintArray(mergeSortedArray);

            // QuickSort
            int[] quickSortedArray = (int[])array.Clone();
            QuickSort.Sort(quickSortedArray, 0, quickSortedArray.Length - 1);
            Console.WriteLine("Quick Sorted array:");
            PrintArray(quickSortedArray);

            // SelectionSort
            int[] selectionSortedArray = (int[])array.Clone();
            SelectionSort.Sort(selectionSortedArray);
            Console.WriteLine("Selection Sorted array:");
            PrintArray(selectionSortedArray);

            // ShellSort
            int[] shellSortedArray = (int[])array.Clone();
            ShellSort.Sort(shellSortedArray);
            Console.WriteLine("Shell Sorted array:");
            PrintArray(shellSortedArray);

            // InsertionSort
            int[] insertionSortedArray = (int[])array.Clone();
            InsertionSort.Sort(insertionSortedArray);
            Console.WriteLine("Insertion Sorted array:");
            PrintArray(insertionSortedArray);
        }

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
