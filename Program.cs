//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
     
string[] arrayFirst = new string[5] {"joker", "hi", "hello", "one", "fire"};
string[] arraySecond = new string[arrayFirst.Length];

void CompletionSecondArray(string[] arrayFirst, string[] arraySecond)
{
int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {     
        if(arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CompletionSecondArray(arrayFirst, arraySecond);
PrintArray(arraySecond);

