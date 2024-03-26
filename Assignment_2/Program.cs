//Take user input and keep in an array. Number which are divisible by 3 keep them in a new array.

int[] number = new int[3];
int i = 0;
int[] divisible = new int[number.Length];
for (i = 0; i < number.Length; i++)
{
    Console.WriteLine($"Enter {i + 1} Number");
    number[i] = Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine("The Array is Written below");
for (i = 0; i < number.Length; i++)
{
    Console.WriteLine(number[i]);
    if (number[i] % 3 == 0) 
    {
        divisible[i] = number[i];
       Console.WriteLine($" {number[i]} is divisible");
    }
    else
    {
        Console.WriteLine($"{number[i]} is not divisible by 3");
    }
}

for (i = 0;i < divisible.Length; i++)
{

Console.WriteLine(divisible[i]);
}