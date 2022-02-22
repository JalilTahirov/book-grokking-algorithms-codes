// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;
using CodeExamples;

Console.WriteLine("Hello, World!");

// Chapter 03 Recursion
var chapterCode = new Chapter_03_Recursion();
var mainBox = chapterCode.OrgonizeBoxes();
chapterCode.LookForKeyRecursively(mainBox);
//chapterCode.LookForKey(mainBox);
chapterCode.CountDown(12);



//var result = Chapter_01_BinarySearch.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 4);
//Console.WriteLine(result);
