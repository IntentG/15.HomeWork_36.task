/*Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.    
[3, 7, 23, 12] -> 19     
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Укажите длину массива: ");
int sizeArray = int.Parse(Console.ReadLine());

int[] array = new int[sizeArray];
Random arrayRandomValue = new Random();
int arraySummValue = 0;



for (int i = 0; i < sizeArray; i++)
{
    array[i] = arrayRandomValue.Next(-100, 100);
    Console.Write($" | {array[i]}");

    if (i % 2 != 0)
        arraySummValue += array[i];
}

Console.WriteLine($" \n Сумма элементов массива, стоящих на нечётных позициях = {arraySummValue}");

