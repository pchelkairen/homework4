// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int size = 123;
int[] array = new int[size];
int count = 0;
for (int index = 0; index < size; index++)
    array[index] = new Random().Next(1,999);

Console.WriteLine("Ваш массив ");

for (int index = 0; index < size; index++)
        Console.Write ($"{array[index]} ");


for (int index = 0; index < size; index++)
    if (array[index] >= 9 && array[index] <= 99)
    count++;

Console.WriteLine($"Kоличество элементов из отрезка [10,99] равно {count}");