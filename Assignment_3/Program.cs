/* Print "FizzBuzz" if i is divisible by 3 and 5, "Fizz" if i is divisible by 3,
  "Buzz" if i is divisible by 5, or i(as a string) if none of the conditions are true. */

int[] arr = new int[5]; //Array Declaration with size 5
int i = 0; // Global declaration of i
for ( i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt16(Console.ReadLine()); // user input stored in an array named arr according to index number.
}

for (i=0; i < arr.Length; i++)
{
    if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
   
    else if(arr[i] % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (arr[i] % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else Console.WriteLine(arr[i]);
}