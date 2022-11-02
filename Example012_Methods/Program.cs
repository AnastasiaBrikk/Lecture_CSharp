/* 1 виде метода. Ничего не принимает и ничего не возвращает.
void Metod1()
{
    Console.WriteLine("Автор ...");
}
Чтобы вызвать нужно просто написать Metod1().

2 вид метода. Что-то принимает, но ничего не возвращает.
void Metod2(string msg) — где void ключевое слово, дальше идентификатор, в скобках
указаны какие-то аргументы.
{
    Console.WriteLine(msg); — оператор, в скобках указан принятый аргумент.
}

Вызывать так: Metod2(“Текст сообщения”); — где Metod2 является идентификатором, а в скобках
указан текст, выводимый в консоли.

3 вид методов. Ничего не принимают, но что-то возвращают.
int Metod3() - не принимает никакие аргументы
{
    return DataTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);

4 вид метода. методы, которые что-то принимают и что-то возвращают.

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);
*/

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Синценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Original(string text, char oldValue, char newValue) //текст, первоначальный элемент и элемент, который нужно поставить на его место
{
    string result = String.Empty; //берём пустую строку, куда будем записывать старые и новые элементы. Т е пишем текст с нуля с изменениями.
    int count = text.Length; //находим длину строки (кол-во элементов, с которыми будем работать)
    for(int i = 0; i < count; i++) //начинаем с первого элемента, пока не дойдём до последнего, прибавляем к индексу +1 чтобы перейти к следующему элементу.
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}"; //добавляем символ из страки без изменений.
    }
    return result;
}

string firstText = Original(text, ' ', '|');
string secondText = Original(firstText, 'к', 'К');
string thirdText = Original(secondText, 'С','с');

Console.WriteLine(thirdText);
*/

//Алгоритм сортировки методом выбора. Дан набор чисел 86132457. Отсортировать и привести к 12345678.

// 1. Находим позицию наименьшего элемента в неотсортированной части (цикл).

/*int[] array = {8, 6, 1, 3, 2, 4, 5, 7};

void arrayPrint( int[] array)
{
    int count = array.Length; // кол-во символов равно длине массива.
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void arraySort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for(int j = i+1; j<array.Length; j++)
        {
            if(array[j]<array[minPosition])
            {
            minPosition=j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

arrayPrint(array);
arraySort(array);
arrayPrint(array);
*/

