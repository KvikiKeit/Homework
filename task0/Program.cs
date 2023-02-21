//Урок1

//задача 4
/*Console.WriteLine("Вводим первое число");
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
*/

//Урок2

//Задача 10
Console.WriteLine("Вводим трехзначное число");
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

