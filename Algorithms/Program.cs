﻿using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs");
            Console.WriteLine("<<<<<>>>>>>>>>><<<<<<<<>>>>>>");
            Console.WriteLine("1.Permutation of string");
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
                default:
                    break;
            }

        }
    }
}
