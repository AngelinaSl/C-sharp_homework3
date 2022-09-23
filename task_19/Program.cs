/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


//Решение задачи без применения массива и для пятизначных чисел:


Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x >= 99999 || x < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    int y1 = x / 10000;
    int y2 = (x - y1 * 10000) / 1000;
    int y3 = (x - y1 * 10000 - y2 * 1000) / 100;
    int y4 = (x - y1 * 10000 - y2 * 1000 - y3 * 100) / 10;
    int y5 = x % 10;
    if (y1 == y5 && y2 == y4)
    {
        Console.WriteLine($"Число {x} - палиндром!");
    }
    else
    {
        Console.WriteLine($"Число {x} - не палиндром!");
    }
}



//Решение задачи для любых чисел с помощью массива:

/*
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int index = 0;
int y = x;
while (y > 0)  //цикл, чтоб узнать количество цифр в числе
{
    y = y/10;
    index++;
}

int [] array;  // ввели значения цифр в массив (в обратном порядке)
array = new int[index]; 
int i = 0;
int l = x;
while (i < index) 
{
    array[i] = l % 10;
    l /= 10;
    i++;
}

int ind = 0;   // Сравниваем значение начала массива с его концом
int sorted_size = 1;
if (array[ind] == array[index-sorted_size])
{
    while (i < index - sorted_size )
    {
        ind++;
        sorted_size++;
    }
    Console.WriteLine($"Число {x} -  палиндром!");
}
else 
{
    Console.WriteLine($"Число {x} - не палиндром!");
}
*/

