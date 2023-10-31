public class BenfordsLaw
{
    public static void Main()
    {
        string inputText = "Here's your sample text with numbers like 101, 205, 3005, 400 and so on..."; // Пример для тестирования.
        int[] result = GetBenfordStatistics(inputText);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine($"Число {i}: {result[i]} раз");
        }
    }

    public static int[] GetBenfordStatistics(string text)
    {
        var statistics = new int[10]; // Создаем массив для сбора статистики для каждой цифры (от 0 до 9).
        string[] words = text.Split(' '); // Разбиваем текст на слова по пробелу.
        
        foreach (var word in words)
        {
            if (word.Length > 0 && char.IsDigit(word[0])) // Проверяем, является ли первый символ слова цифрой.
            {
                int digit = int.Parse(word[0].ToString()); // Преобразуем первый символ слова в цифру.
                if (digit >= 0 && digit <= 9) // Подтверждаем, что это цифра от 0 до 9.
                {
                    statistics[digit]++; // Увеличиваем соответствующий счетчик в массиве статистики.
                }
            }
        }

        return statistics; // Возвращаем массив с результатами.
    }
}