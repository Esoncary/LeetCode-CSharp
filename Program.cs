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
        Console.Write(Solution.MaxSatisfied(new int[] { 2, 6, 6, 9 }, new int[] { 0, 0, 1, 1 }, 1));
        //bool a = Solution.RepeatedSubstringPattern("abaababaab");
    }

}


