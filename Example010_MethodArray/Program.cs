int[] array = { 11, 22, 34, 4, 53, 65, 75, 82 };
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
     if(array[index] == find)
     {
        Console.WriteLine(index);
        break;
     }
    index++;
}
