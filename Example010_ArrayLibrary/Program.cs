//void - обозначение функции, кот-я не выводит значение на экран
//заводим массив из случайных чисел от 1 до 10
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        //кладем в collection случайное число от 1 до 10
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

//печатаем полученный массив в массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//создание нового массива, который содержит в себе 10 элементов
int[] array = new int[10];

//вызываем функцию заведения массива
FillArray(array);
//вызываем функцию печати полученного массива
PrintArray(array);