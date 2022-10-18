//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine ("Введите размер массива ");
int size = int.Parse (Console.ReadLine ());
int[] array = new int[size];
int count = 0;
int countn = 0;
for (int index = 0; index < size; index++)
    array[index] = new Random().Next(100,999);

Console.WriteLine("Ваш массив ");

for (int index = 0; index < size; index++)
    Console.Write ($"{array[index]} ");

for (int index = 0; index < size; index++)
    if (array[index] % 2 == 0)
    count++;
    else 
    countn++;

Console.WriteLine($"Kоличество нечетных чисел {countn}, четных чисел {count}");


