/*
string[,] table = new string[2,5];
table[1,2] = "word";
for(int rows=0; rows< 2; rows++)
{
    for(int columns=0; columns<5; columns++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}


int[,] matrix = new int[3,4];
for(int i = 0; i< matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}


void PrintArray(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10); //[1, 9]
        }
    }
}

int[,] matrix = new int[3,4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
*/

//Задача данную в задаче закрасить картинку при 0- закрашенный пиксель, 1 - незакрашенный.

/*
int [,] pic = new int[23,25];
...картинка...
//Метод, выводящий новую картинку:

void PrintImage(int[,] image)
{
    for(int i=0; i<image.GetLength(0); i++)
    {
        for(int j=0; j<image.GetLength(1); j++)
        {
            if(image[i,j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

//Метод, закрашивающий картинку:

void FillImage(int row, int col)
{
    if(pic[row,col] == 0)
    {
        pic[row,col] = 1;
        FillImage(row-1,col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(pic);
PrintImage(pic);
//Методы подходят для закрашивания небольших картинок.

Рекурсия - метод, который вызывает сам себя.

//Задача. Найти факториал числа.

int Factorial(int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}

Переполнение случится с 17!.

//Задача. Найти фибоначии числа. Фибоначии - каждое следующее число равно сумме двух предыдущих.
Например, 1 1 2 3 5 8 13 ..

Формула в математике: Fn = F(n-1) + F(n-2)

!!!
Фибоначчи(1) = 1.
Фибоначчи(2) = 1.

Метод:
int Fibonacci(int n)
{
    if(n==1||n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}

for(int i =1; i<10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
//При i>= 30 процесс начнёт тормозить.*/ 