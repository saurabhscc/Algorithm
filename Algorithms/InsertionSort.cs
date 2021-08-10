﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class InsertionSort
    {
        public void PrintArray(string[] arr)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        // Function to sort array
        public void Sort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                string max = arr[i];
                int j = i - 1;
                //Searching for minimum element in the array and move to the first position
                while (j >= 0 && arr[j].Length > max.Length)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = max;
            }
        }
    }
}
