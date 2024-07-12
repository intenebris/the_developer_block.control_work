// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Main()
{
    //На старте выполнения были заданы массивы. Для выбора одного из заданных массивов был использован метод switch.
    System.Console.WriteLine("Выберите один из массивов:");
    Console.WriteLine("1 - [“Hello”, “2”, “world”, “:-)”] \n2 - [“1234”, “1567”, “-2”, “computer science”] \n3 - [“Russia”, “Denmark”, “Kazan”]");
    string[] array = new string[] { };
    string? inputArray = InputOption("Для выбора введите цифру, соответствующую номеру массива: ");
    switch (inputArray)
    {
        case "1":
            array = new string[] { "Hello", "2", "world", ":-)" };
            break;
        case "2":
            array = new string[] { "1234", "1567", "-2", "computer science" };
            break;
        case "3":
            array = new string[] { "Russia", "Denmark", "Kazan" };
            break;
        default:
            Console.WriteLine($"{inputArray} - Такого массива нет. Попробуйте еще раз.");
            break;
    }
    PrintNewArray(array, 3);


}
// Способ ввода данных с клавиатуры в консоле был выделен в отдельную функцию
string? InputOption(string msg)
{
    System.Console.Write(msg);
    return Console.ReadLine();
}

// В первую очередь мы вычисляем размер нового массива, который будет сформирован из строк старого массива длина которых меньше, либо равна 3 символам.
int FindSizeArray(string[] arr, int maxLength)
{
    int sizeNewArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength) sizeNewArray++;
    }
    return sizeNewArray;
}

// Далее, зная размер нового массива, создаем сам новый массив.
string[] CreateNewArray(string[] arr, int maxLength)
{
    string[] tempArray = new string[FindSizeArray(arr, maxLength)];
    int indexNewArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength)
        {
            tempArray[indexNewArray] = arr[i];
            indexNewArray++;
        }
    }
    return tempArray;
}

// В завершении создаем функцию для вывода получившегося результата в консоль.
void PrintNewArray(string[] arr, int maxLength)
{
    string[] resultArray = CreateNewArray(arr, maxLength);
    if (resultArray.Length == 0)
    {
        System.Console.WriteLine(" ");
    }
    else
        for (int i = 0; i < resultArray.Length; i++)
        {
            if (i == resultArray.Length - 1)
                Console.Write($"“{resultArray[i]}”\n");
            else
                Console.Write($"“{resultArray[i]}”, ");
        }
}

Main();
