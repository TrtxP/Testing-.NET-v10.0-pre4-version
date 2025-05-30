// Этот код демонстрирует использование паттернов сопоставления с образцом в C# 13.0

int[] numbers = { 1, 2, 3, 4, 5 };

if (numbers is [1, 2, .. var rest])
{
    Console.WriteLine("Массив начинается с 1, 2 и содержит: " + string.Join(", ", rest));
    Console.WriteLine($"Длина оставшейся части: {rest.Length}");
}
else
{
    Console.WriteLine("Массив не начинается с 1, 2");
}

object value = 5.6;

if (value is int or double)
{
    Console.WriteLine("Значение является целым числом или числом с плавающей запятой.");
}
else if (value is string str)
{
    Console.WriteLine($"Значение является строкой: {str}");
}
else
{
    Console.WriteLine("Значение не является ни целым числом, ни числом с плавающей запятой, ни строкой.");
}

Console.WriteLine();

object input = GetInput();

string result = input switch
{
    int m when m > 0 => "Положительное целое число",
    int m when m < 0 => "Отрицательное целое число",
    double d when d >= 0 => "Положительное число с плавающей запятой",
    double d when d < 0 => "Отрицательное число с плавающей запятой",
    string s => s.Length switch
    {
        > 10 => "Очень длинная строка",
        > 8 => "Длинная строка",
        > 5 => "Средняя строка",
        _ => "Короткая строка"
    },
    null => "Значение равно null",
    _ => "Неизвестный тип"
};

Console.WriteLine($"Результат сопоставления: {result}");

static object GetInput()
{
    return -56.3;
}