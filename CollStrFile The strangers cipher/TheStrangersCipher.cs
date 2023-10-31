using System;
using System.Collections.Generic;

class TheStrangersCipher
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк в вашем послании:");
        int numLines = int.Parse(Console.ReadLine());

        string[] lines = new string[numLines];
        
        Console.WriteLine("Введите ваше послание построчно:");
        for (int i = 0; i < numLines; i++)
        {
            lines[i] = Console.ReadLine();
        }

        string decodedMessage = DecodeMessage(lines);
        Console.WriteLine("\nРасшифрованное сообщение:");
        Console.WriteLine(decodedMessage);
    }

    private static string DecodeMessage(string[] lines)
    {
        List<string> words = new List<string>(); //Делаем список со словами куда будем добавлять слова с большой буквы

        foreach (string line in lines) //Перебираем каждую строку из входного массива
        {
            string[] lineWords = line.Split(' '); //Разбиваем строку на слова

            foreach (string word in lineWords) //Перебираем каждое слово из строки
            {
                if (!string.IsNullOrWhiteSpace(word) && char.IsUpper(word[0])) //слово не пустое и начинается с большой буквы
                {
                    words.Add(word); //добавляем в наш список
                }
            }
        }

        words.Reverse(); //переворачиваем список в обратном порядке

        string decodedMessage = string.Join(" ", words); //объединяем все слова в одну строчку

        return decodedMessage;
    }
}