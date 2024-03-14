// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished");

static double GetAvg(int[] num)
{
    double s=0;
    for (int i = 0; i < num.Length; i++)
    {
        s+=numb[i];
    }

    return s / num.Length;
}

int[] a = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(a));