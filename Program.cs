// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

using System;
using System.Reflection.Metadata.Ecma335;
using System.Formats.Asn1;
using System.Reflection;
using Microsoft.VisualBasic;

class Program
{

    static void Main(string[] args)
    {
        Console.Write(Solution.GetAverages(new int[] { 7, 4, 3, 9, 1, 8, 5, 2, 6 }, 3));
        //bool a = Solution.RepeatedSubstringPattern("abaababaab");
    }

}


