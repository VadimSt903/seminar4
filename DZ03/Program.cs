/*
Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
*/
var number = new int[8];
Console.WriteLine("Введите первое число массива: ");
number[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число массива: ");
number[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число массива: ");
number[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое число массива: ");
number[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число массива: ");
number[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите шестое число массива: ");
number[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите седьмое число массива: ");
number[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите восьмое число массива: ");
number[7] = Convert.ToInt32(Console.ReadLine());
foreach (int i in number)

{
   Console.Write(i);
    
}
