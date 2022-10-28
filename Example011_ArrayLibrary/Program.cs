void FillArray(int[] fill)
{
    int length = fill.Length;
    int index = 0;
    while(index<length)
    {
        fill[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] print)
{
    int count = print.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(print[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
