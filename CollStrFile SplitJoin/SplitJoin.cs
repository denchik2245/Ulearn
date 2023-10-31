public class BenfordsLaw
{
    public static void Main()
    {
        // Пример текста с различными разделителями для теста.
        string sampleText = "Country:USA-Population:328M\nCountry:India;Population:1.3B\nCountry:China,Population:1.4B";
    
        string result = ReplaceIncorrectSeparators(sampleText);
        Console.WriteLine(result);
    }

    public static string ReplaceIncorrectSeparators(string text)
    {
        // Разбиваем входной текст на строки по символам новой строки ('\n' и '\r').
        string[] lines = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        
        string result = ""; // Создаем пустую строку для хранения результата.
        
        foreach (string line in lines) // Проходим по каждой строке из разделенного текста.
        {
            // Разбиваем строку на части, используя разные разделители.
            string[] parts = line.Split(new char[] { ' ', ':', ';', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Если в строке найдено 4 или больше частей, добавляем их в результирующую строку, разделяя символом табуляции.
            if (parts.Length >= 4)
                result += parts[0] + "\t" + parts[1] + "\t" + parts[2] + "\t" + parts[3] + "\n";
        }
        return result;
    }

}