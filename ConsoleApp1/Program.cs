//Array Max Min Value

int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Enter Number {i + 1}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Values are");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
//int max = arr.Max();
//int min = arr.Min();
//Console.WriteLine($"max : {max}  min {min}");
//if (maxvalue < arr[1])
//{
//    maxvalue = arr[1]; 
//}
//if (maxvalue < arr[2])
//{
//    maxvalue = arr[2];
//}
//if (maxvalue < arr[3])
//{
//    maxvalue = arr[3];
//}
//if (maxvalue < arr[4])
//{
//    maxvalue = arr[4];
//}

int maxvalue = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (maxvalue < arr[i])
    {
        maxvalue = arr[i];
    }
}

Console.WriteLine($"Max value: {maxvalue}");


int minvalue = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (minvalue > arr[i])
    {
        minvalue = arr[i];
    }
}

Console.WriteLine($"M value: {minvalue}");