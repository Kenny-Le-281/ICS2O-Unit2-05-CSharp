// Created by: Kenny Le
// Created on: Mar 2022
//
// This program does calculation

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a triangle
        const double TAX_RATE = 0.18;
        double numbersOfHoursWorked;
        double hourlyRate;
        double takeHomeSalary;
        double governmentTax;

        // input
        Console.WriteLine("This program determines your pay.");
        Console.WriteLine("");

        Console.Write("Enter the numbers of hours worked: ");
        numbersOfHoursWorked = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the hourly rate: ");
        hourlyRate = Convert.ToDouble(Console.ReadLine());
       
        
        // process
        Console.WriteLine("");
        takeHomeSalary = (numbersOfHoursWorked * hourlyRate) * (1.00 - TAX_RATE);
        governmentTax = (numbersOfHoursWorked * hourlyRate) * TAX_RATE;

        // output
        Console.WriteLine("Your pay will be: $ " + takeHomeSalary.ToString("0.00"));
        Console.WriteLine("The government will take: $ " + governmentTax.ToString("0.00"));

        Console.WriteLine("\nDone.");
    }
}
        