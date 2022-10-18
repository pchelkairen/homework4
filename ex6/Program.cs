// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int size = 5;
int[] array = new int[size];
int a = 0;
int b = 0;
int comp = 0;
for (int index = 0; index < size; index++)
    array[index] = new Random().Next(1,5);

Console.WriteLine("Ваш массив ");

for (int index = 0; index < size; index++)
        Console.Write ($"{array[index]} ");


for (int index = 0; index < size; index++)
    if(index <= (size / 2))
        a = array [index + 1];
        b = array [size - 1];
        comp = a * b;
        size = size - 1;
    
Console.WriteLine($"произведение пар чисел в одномерном массиве равнo {comp}");