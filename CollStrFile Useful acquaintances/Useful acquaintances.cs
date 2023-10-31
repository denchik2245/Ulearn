class UsefulAcquaintances
{
    private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>(); // Создание пустого словаря
        
        foreach(var contact in contacts) // Перебор всех контактов из списка
        { 
            string temp = contact.Replace("<","").Replace(">",""); // Удаление символов '<' и '>'
            var input = temp.Split(':').ToArray() ; // Разделение строки на имя и email по символу ':'
            string words = input[0].Length > 1 ? input[0].Substring(0,2) : input[0]; // Получение первых двух букв имени (или одной, если имя состоит из одной буквы)

            // Проверка наличия ключа в словаре и добавление нового списка при необходимости
            if (!dictionary.ContainsKey(words))
                dictionary.Add(words, new List<string>());
            
            dictionary[words].Add(temp); // Добавление email в список для соответствующего ключа
        }
        
        return dictionary; // Возвращение полученного словаря
    }
    
    public static void Main(string[] args)
    {
        var contacts = new List<string>
        {
            "<Sa:sasha1995@sasha.ru>",
            "<Al:alex99@mail.ru>",
            "<Sh:shurik2020@google.com>"
        };
        
        var optimizedContacts = OptimizeContacts(contacts);
        
        foreach (var key in optimizedContacts.Keys)
        {
            Console.WriteLine($"{key}: {string.Join(", ", optimizedContacts[key])}");
        }
    }
}
