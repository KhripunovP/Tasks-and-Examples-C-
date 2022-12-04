// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] Numbers(string[] numbersStr)
{
    int[] numbersInt = new int[numbersStr.Length];
    for (int i = 0; i < numbersStr.Length; i++)
    {
        numbersInt[i] = Convert.ToInt32(numbersStr[i]);
    }
    return numbersInt;
}

int PositiveNumbers(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            pos = pos + 1;
    }
    return pos;
}

Console.WriteLine("Веедите числа через запятую");
string[] str = Console.ReadLine().Split(',');

int[] num = Numbers(str);
int result = PositiveNumbers(num);

Console.WriteLine($"Чисел больше 0 -> {result}");