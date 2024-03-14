// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");

static double GetAvg(int[] numbers)
{
    double s=0;
    for (int i = 0; i < numbers.Length; i++)
    {
        s+=numbers[i];
    }

    return s / numbers.Length;
}

int[] a = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(a));