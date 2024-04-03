﻿/*1009
---------
Make a program that reads a seller's name, his/her fixed salary and the sale's total made by himself/herself in the month (in money). Considering that this seller receives 15% over all products sold, write the final salary (total) of this seller at the end of the month , with two decimal places.

- Don’t forget to print the line's end after the result, otherwise you will receive “Presentation Error”.

- Don’t forget the blank spaces.

Input
The input file contains a text (employee's first name), and two double precision values, that are the seller's salary and the total value sold by him/her.

Output
Print the seller's total salary, according to the given example.
*/

Console.WriteLine("Seller First Name: ");
string name = Console.ReadLine();

Console.WriteLine("Fixed Salary in a Month: ");
double fixedSalary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Total Sell in a Month: ");
double totalSell = Convert.ToDouble(Console.ReadLine());

double percentage = 15.0 / 100.0;
double total = (fixedSalary + (totalSell * percentage));

Console.WriteLine("Seller Total Salary = " + total);