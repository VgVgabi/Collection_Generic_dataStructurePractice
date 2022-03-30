﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Collection_Generic_dataStructurePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> cll = new CustomLinkedList<int>();
            cll.Add(1);
            cll.Add(2);
            cll.Add(3);
            System.Console.WriteLine("Enumarating CustomLinkedList items with");
            System.Console.WriteLine("GetEnumerator:");
            foreach (var item in cll)
                System.Console.WriteLine(item);
            //
            System.Console.WriteLine("GetEnumerableDESC:");
            foreach (var item in cll.GetEnumerableDESC())
                System.Console.WriteLine(item);

        }
    }
}