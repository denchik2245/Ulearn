using System.Text;

public class StrangerAgain
{
    public static void Main()
    {
        string[] sampleCommands = {
            "push Привет! Это снова я! Пока!",
            "pop 5",
            "push Как твои успехи? Плохо?",
            "push qwertyuiop",
            "push 1234567890",
            "pop 26"
        };
        
        string result = ApplyCommands(sampleCommands);
        Console.WriteLine(result);
    }

    private static string ApplyCommands(string[] commands)
    {
        var sb = new StringBuilder();
        
        foreach (var com in commands) // Проходимся по каждой команде в переданном массиве команд.
        {
            switch (com[1]) // Проверяем второй символ команды для определения типа команды.
            {
                // Если команда начинается на "pu" (push), то добавляем строку после "push " в StringBuilder.
                case 'u':
                    sb.Append(com.Substring(5));
                    break;
                // Если команда начинается на "po" (pop), то удаляем указанное количество символов из конца строки.
                case 'o':
                    sb.Length -= int.Parse(com.Substring(4));
                    break;
            }
        }
        return sb.ToString();
    }
}