//Declare an Array and take input from user. find min and max value
// declare an array and take input from user. find the number which are divisible by 3 print the number in a different array.

int[] array = new int[3];
int i = 0;
for (i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Enter {i + 1} Number");
    array[i] = Convert.ToInt16(Console.ReadLine());
}

for (i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

if (i)