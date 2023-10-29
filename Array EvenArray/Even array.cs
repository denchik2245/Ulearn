public class Program
{
    public static int[] GetFirstEvenNumbers(int count)
    {
        
        int[] array = new int[count]; // Создаем новый массив целых чисел длиной count.
        for (int i = 0; i < array.Length; i++) // Итерируем по элементам массива, начиная с 0.
        {
            // Заполняем текущий элемент массива четным числом.
            // 0 индекс = (0+1)*2 = 2
            // 1 индекс = (1+1)*2 = 4
            array[i] = (i + 1) * 2;
        }
        return array;
    }

    public static void Main()
    {
        Console.WriteLine("Введите количество четных чисел: ");
        int count = int.Parse(Console.ReadLine()); // Вводим количество четных чисел, которые мы хотим получить.
        int[] evenNumbers = GetFirstEvenNumbers(count);

        // Вывод полученных четных чисел.
        Console.WriteLine($"Первые {count} четных чисел:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
}