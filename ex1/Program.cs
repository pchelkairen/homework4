// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]}");
    }
    Console.WriteLine ();

}
int [] array = {0,1,0,0,0,1,1,0};

PrintArray (array);
