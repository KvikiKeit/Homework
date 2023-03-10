//Урок1
//задача 2:
/*Console.WriteLine("вводим первое число");
    int firstNomber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввести второе число");
    int firstNomber = Convert.ToInt32(Console.ReadLine);
    if (первое число > второе число)
    Console.WriteLine(firstNomber + " > " + secondNumder);
    else if (второе число >пкрвое число)
    Console.WriteLine(secondNumder + " > " + firstNomber);
    Console.WriteLine (secondNumder + " = " + firstNomber);

//задача 4
Console.WriteLine("Вводим первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int num3 = Convert.ToInt32(Console.ReadLine());
        int max = num1;
        if(num1 > max) max = num1;
        if(num2 > max) max = num2;
        if(num3 > max) max = num3;
        Console.WriteLine("max = ");
        Console.WriteLine(max);

//Задача 6
Console.WriteLine("Вводим число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
Console.WriteLine(number + " - Четное число ");
else
Console.WriteLine (number + " - Нечетное число");

//Задача 8
Console.WriteLine(вводим число);
int num = Convert.ToInt32(Console.ReadLine);
int startNumber = 1;

else if (startNumber % 2 == 0)
Console. (startNumber + ", ");
startNumber ++;
*/

//Урок2
//Задача 10
/*Console.WriteLine("Вводим трехзначное число");
    String num = Console.ReadLine();
    Char secondNum = num[1];
    Console.WriteLine("второе число = " + secondNum);

//Задача 13
Console.WriteLine("Вводим трехзначное число");
    String number = Console.ReadLine();
    String result = "Третьей цифры нет";
    if (number.Length >= 3) {
        Char thirdNum = number[2];
        result = "третье число = " + thirdNum;
    }
    Console.WriteLine(result);

//Задача 15
Console.WriteLine("Вводим день недели");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());
        String resultDay = "Будний день";
        if (dayOfWeek > 7 || dayOfWeek < 1) resultDay = "Неверный день недели";
        else if(dayOfWeek > 5) resultDay = "Выходной день";
        Console.WriteLine(resultDay); 
*/


//Урок3
//Задача 19
/*Console.Clear();
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());
int a1 = num / 10000;
int a2 = num / 1000 % 10;
int a4 = num / 10 % 10;
int a5 = num % 10;
//Console.WriteLine($"{a1} {a2} {a4} {a5}");
if (num <= 100000 && num=> 10000)
{
    if (a1 == a5 && a2 == a4)
    {
    Console.Write("да");
    }
    else 
    {
    Console.Write("нет");
    }
}
else
{
    Console.WriteLine("вы ввели не пятизначное число");
}
 
 int Prompt(String message);
{
    Console.Write(message);
    String value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a;
    while (temp > 0)
    {
        revNum = revNum * 10 + temp % 10;
        temp /= 10;
    }
    return revNum;
}

int a = Prompt("Введите 5-ти значное число");
int reversed = ReverseNumber(a);

if (a > 9999 && a <1000000)
{
    if (reversed == a)
    {
        Console.WriteLine("Число является полиндромом. ");
    }
    else
    {
        Console.WriteLine("Число НЕ является полиндромом. ");
    }
}

//Задача 21
//напишите программу, которая принимает на вход координаты 2х точек и находит растояние между ними в 3Д пространстве.
//AB = v(xb - xa)2 + (yb - ya)2

Console.Write("введение координаты X1 : ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("введение координаты Y1 : ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("введение координаты Z1 : ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("введение координаты X2 : ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("введение координаты Y2 : ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("введение координаты Z2 : ");
int Z2 = int.Parse(Console.ReadLine()!);
int A = (X2 - X1)*(X2 - X1);
int B = (Y2 - Y1)*(Y2 - Y1);
int C = (Z2 - Z1)*(Z2 - Z1);
double ABC = Math.Sqrt(A + B + C);
Console.Write(ABC);

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
while(x <= N)
{
    int y = x*x*x;
    Console.WriteLine(y);
    x++
} */

//Урок 4. Функции
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

int Prompt(String message)
{
    System.Console.Write(message);
    String readInput = System.Console.ReadLine();
    int result = int. Parse(readInput);
    return result;
}
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);
// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
*/

/*Задача 27:
int Prompt(String message)
{
    System.Console.Write(message);
    String readInput = System.Console.ReadLine();
    int result = int. Parse(readInput);
    return result;
}
String num = ReadInt("Введите число");
CalculateSum(num);
{
    int num1 = num[2].ToInt32
    int num2 = num[1].ToInt32
    int num3 = num[0].ToInt32
    int result = num1 + num2 + num3
    Console.WriteLine(result);
}*/

//Задача 29:
//не получилось

//Задача 34

//Console.WriteLine("Введите длину массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//RandonNumbers(numbers);
//Console.WriteLine("В этом массиве");
//PrintArray(numbers);

//void RandonNumbers(int[] numbers)
//{
//    for(int i = 0; i < size; i++)
//    {
//        numbers[i] = new Random().Next(100,1000);
//    }
//}
//int count = 0;
//for (int x = 0; x < numbers.Length; x++)
//{
//if (numbers[x] % 2 == 0)
//count++;
//}
//Console.WriteLine($"из {numbers.Length} чисел, {count} четных");
//void PrintArray(int[] numbers)
//{
//    Console.Write(" ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//    Console.Write(" ");
//    Console.WriteLine();
//}

//Задача 36

//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.WriteLine("массив");
//PrintArray(numbers);
//int sum = 0; 

//for (int z = 0; z < numbers.Length; z+=2)
//    sum = sum + numbers[z];

//    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

//void FillArrayRandomNumbers(int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = new Random().Next(1,10);
//        }
//}
//void PrintArray(int[] numbers)
//{
//    Console.Write(" ");
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write(numbers[i] + " ");
//        }
 //   Console.Write(" ");
//    Console.WriteLine();
//}

//Задача 38

//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//double[] numbers = new double[size];
//FillArrayRandomNumbers(numbers); 
//Console.WriteLine("массив");
//PrintArray(numbers);
//double min = Int32.MaxValue; // минимальное значение 
//double max = Int32.MinValue; // значение мах
//for (int х = 0; х < numbers.Length; х++)
//{
//    if (numbers[х] > max)
//        {
//            max = numbers[х];
//        }
//    if (numbers[х] < min)
//        {
//            min = numbers[х];
//        }
//}
//void FillArrayRandomNumbers(double[] numbers) // переменная , генератор случайных чисел
//{
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//        }
//}
//void PrintArray(double[] numbers)
//{
//    Console.Write(" ");
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    Console.Write(" ");
//    Console.WriteLine;
//} 

//урок 6

//Задача 41

Console.Write("Введите числа через запятую");
int[] numbers = StringToNum(Console.ReadLine);
Console.WriteLine($"введите {number} целых чисел:");
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine;
Console.WriteLine($"количество значений больше 0 = {sum}");
int[] StringToNum(string array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (inputarray[i] == ',')
        {
            count++;
        }
    }
    int numbers = new int [count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string temp = " ";
        while (array [i])
        {
        if(i != array.Length - 1)
        {
            temp += array [i].ToString;
            i++;
        }
        else
        {
            temp += array [i].ToString;
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
void PrintArray(int array)
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ");
}

// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// x(k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

String GetPointOfIntersection(int k1, int k2, int b1, int b2)
{
    string str43 = "Найти точку пересечения двух прямых:";
    Console.WriteLine(str43); 
    Console.WriteLine($"y = {k1}*x + {b1}");
    Console.WriteLine($"y = {k2}*x + {b2}");

    if (k1 - k2 != 0)
    {
        float x = (float)(b2 - b1) / (float)(k1 - k2);
        float y = k1 * x + b1;

        return $"точка пересечения ({x:f1} ; {y:f1})";
    }
    else
    {
        return "прямые не пересекаются или совпадают";
    }
}

int b1 = 2, // y = k1 * x + b1
    k1 = 5,
    b2 = 4, // y = k2 * x + b2
    k2 = 9;
Console.WriteLine(GetPointOfIntersection(k1, k2, b1, b2));

//урок 7

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
// 17 -> такого числа в массиве нет

int rows = ReadInt("Введите индекс строки");
int colums = ReadInt("Введите индекс столбца");
int[] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода массива
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int rows = ReadInt("Введите номер строки: ");
// int colums = ReadInt("Введите номер столбца: ");

int rows = 3;
int colums = 4;
int[] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); i++)
    {
        result += numbers[i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArray(avgNumbers);
// Заполнение массива рандомными вещественными числами
void FillArray2D(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[i] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода двумерного массива в терминал
void PrintArray2D(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; i < array.GetLength(1); i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Функция вывода массива в терминал 
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine);
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);
// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] CreateMatrix1 (int row, int col, int min, int max) 
{
    int[,] matrix1 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix1;
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max) 
{
    int[,] matrix2 = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix2;
} 
 
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}
 
void DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int aRows = matrix1.Length[0]; int aCols = matrix1[1].Length;
    int bRows = matrix2.Length[0]; int bCols = matrix2[1].Length;
    if (aCols != bRows)    
    double[][] result = MatrixCreate(aRows, bCols);
    for (int i = 0; i < aRows; i++) 
        for (int j = 0; j < bCols; j++) 
        for (int k = 0; k < aCols; k++)
        result[i][j] += matrix1[i][k] * matrix2[k][j];
    return result;
}
 
int[,] array2D = CreateMatrix1(2, 2, 0, 9);
int[,] matrix = CreateMatrix2(2, 2, 0, 9);
PrintMatrix1(array2D);
Console.WriteLine();
PrintMatrix2(array2D);
DivMatrix();

//Дополнительные задачи:
//Задача 60. * ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);
// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k})");
            }
        }
    }
}
// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

//Задача 62 *. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
PrintArray(nums);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine(" ");
    }
}

//урок 9
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}
NumberCounter(number);

/*
 Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);
// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}
// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}