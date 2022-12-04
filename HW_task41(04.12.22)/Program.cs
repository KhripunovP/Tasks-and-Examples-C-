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

int MaxNumber(int[] array)
{
    int i = 0;
    int max = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

Console.WriteLine("Веедите числа через запятую");
string[] str = Console.ReadLine().Split(',');

int[] num = Numbers(str);
int result = MaxNumber(num);

Console.WriteLine($"Максимальное число из введенных = {result}");