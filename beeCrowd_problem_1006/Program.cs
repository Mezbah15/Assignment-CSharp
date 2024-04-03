/*1006
-------
Read three values (variables A, B and C), which are the three student's grades. Then, calculate the average, considering that grade A has weight 2, grade B has weight 3 and the grade C has weight 5. Consider that each grade can go from 0 to 10.0, always with one decimal place.

Input
The input file contains 3 values of floating points (double) with one digit after the decimal point.

Output
Print the message "MEDIA"(average in Portuguese) and the student's average according to the following example, with a blank space before and after the equal signal.

 */

Console.WriteLine("Enter three student grade respectively: ");
double A = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
double B = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
double C = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);

A = Math.Max(0, Math.Min(10 , A));

double MEDIA = (A + B + C) / 3;

Console.WriteLine("MEDIA = " + MEDIA);