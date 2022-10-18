// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int size = 5;
int[] array = new int[size];
int a = 1;
int b = 1;
int comp = 0;
int min = 1;
int max = 1;
for (int index = 0; index < size; index++)
    array[index] = new Random().Next(1,5);

Console.WriteLine("Ваш массив ");

for (int index = 0; index < size; index++)
        Console.Write ($"{array[index]} ");


for (int index = 0; index < size; index++)
    if (a > b)
    a = max;
    b = min;
    a = array [index + 1];
    b = array [size - 1];
    comp = a * b;
    size = size - 1;
    
       
    
Console.WriteLine($"произведение пар чисел в одномерном массиве равнo {comp}");