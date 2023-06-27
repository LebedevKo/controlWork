 
//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.WriteLine("Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] originalArray = new string[count];
string[] newArray;
int resultCount = 0;


for (int i = 0; i < count; i++)
{
    Console.WriteLine("Введите строку:");
    originalArray[i] = Console.ReadLine();
}

for (int i = 0; i < count; i++)
{
    if (originalArray[i].Length <= 3)
    {
        resultCount++;
    }
}