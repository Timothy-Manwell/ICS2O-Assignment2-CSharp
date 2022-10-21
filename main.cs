// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program calculates the area of a triangle
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseOfTriangle;
        int height;
        int area;

        Console.WriteLine("Area of a Triangle Calculator");
        Console.WriteLine("\nThis program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the base (cm): ");
        baseOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = (baseOfTriangle * height) / 2;
        Console.WriteLine("\nThe area is: " + area + " cm².");
        Console.WriteLine("\nDone.");
    }
}