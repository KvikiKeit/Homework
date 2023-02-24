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
Console.Clear();
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
}