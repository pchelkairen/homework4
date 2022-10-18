// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int size = 10;
int[] array = new int[size];
int count = 0;
int sum = 0;
for (int index = 0; index < size; index++)
    array[index] = new Random().Next(1,5);

Console.WriteLine("Ваш массив ");

for (int index = 0; index < size; index++)
        Console.Write ($"{array[index]} ");


for (int index = 0; index < size; index++)
    if (index % 2 != 0)
    sum = sum + 1;
    
Console.WriteLine($"Cуммa чисел одномерного массива стоящих на нечетной позиции равнa {sum}");