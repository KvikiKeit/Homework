﻿//Урок1
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

Урок 4. Функции
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

Задача 29:
//не получилось

Задача 34

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
int count = 0;
for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");
void PrintArray(int[] numbers)
{
    Console.Write(" ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}

Задача 36

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write(" ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write(" ");
    Console.WriteLine();
}

Задача 38

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers); 
Console.WriteLine("массив");
PrintArray(numbers);
double min = Int32.MaxValue; // минимальное значение 
double max = Int32.MinValue; // значение мах
for (int х = 0; х < numbers.Length; х++)
{
    if (numbers[х] > max)
        {
            max = numbers[х];
        }
    if (numbers[х] < min)
        {
            min = numbers[х];
        }
}
void FillArrayRandomNumbers(double[] numbers) // переменная , генератор случайных чисел
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write(" ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write(" ");
    Console.WriteLine;
}