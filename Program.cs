/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
вьполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами. */

Console.WriteLine("Введите значения через пробел");
string s = Console.ReadLine();
string[] initArray = s.Split(' ');
string[] resultArray = threeDigit(initArray);
Console.WriteLine("[" + String.Join(", ", resultArray) + "]");
string[] threeDigit(string[] initArray)
{
    string[] resultArray = new string[0];
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= 3)
            resultArray = addElementToArray(initArray[i], resultArray);
    }
    return resultArray;
}
string[] addElementToArray(string element, string[] array)
{
    string[] newArray = new string[array.Length + 1];
    for (int j = 0; j < array.Length; j++)
        newArray[j] = array[j];
    newArray[newArray.Length - 1] = element;
    return newArray;
}