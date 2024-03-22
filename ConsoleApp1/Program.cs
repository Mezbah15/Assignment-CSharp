// See https://aka.ms/new-console-template for more information

/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Enter value   {i + 1}  : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Values in the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
*/

/*
int val = Convert.ToInt32(Console.ReadLine());

int[] array = new int[10];
array[0] = val;
array[1] = ;
Console.WriteLine(val);

int val2  = Convert.ToInt32(Console.ReadLine());
int val3  = Convert.ToInt32(Console.ReadLine());
int val4 = Convert.ToInt32(Console.ReadLine());
int val5  = Convert.ToInt32(Console.ReadLine());

int[] array = new int[5]; //array declare

array[0] = val;
array[1] = val2;
array[2] = val3;
array[3] = val4;
array[4] = val5;


Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine(array[3]);
Console.WriteLine(array[4]);
*/


using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
             Console.WriteLine($"Enter Number {i + 1}");
             arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Values are");
        for (int i = 0;i < arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    
}