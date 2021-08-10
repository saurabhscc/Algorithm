using System;
using System.Collections.Generic;
using System.IO;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs");
            Console.WriteLine("<<<<<>>>>>>>>>><<<<<<<<>>>>>>");
            Console.WriteLine("1.Permutation of string");
            Console.WriteLine("2.Binary search word");
            Console.WriteLine("3.Insertion Sort");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter The  String : ");
                    string str = Console.ReadLine();
                    int length = str.Length;
                    Permutation.permute(str, 0, length - 1);
                    break;
                case 2:
                    string filepath = File.ReadAllText(@"D:\AlgorithmPrograms\Algorithms\WordList.txt");
                    List<string> list = new List<string>(filepath.Split(' '));
                    list.Sort();
                    BinarySearch.BinarySearchWord(list);
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    string[] arr = { "Hello","I","am","Working", "On" ,"Algorithm" ,"Problems" };
                    insertionSort.Sort(arr); 
                    insertionSort.PrintArray(arr);
                    break;
                default:
                    break;
            }
        }
    }
}
