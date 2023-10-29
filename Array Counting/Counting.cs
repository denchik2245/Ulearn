public class Counting
{
    public static int GetElementCount(int[] items, int itemToCount)
    {
        // Инициализируем переменную count для подсчета количества вхождений элемента itemToCount.
        int count = 0;

        // Итерируем по элементам массива items.
        for (int i = 0; i < items.Length; i++)
        {
            // Проверяем, равен ли текущий элемент itemToCount.
            if (items[i] == itemToCount)
            {
                // Если да, увеличиваем счетчик count на 1.
                count += 1;
            }
        }

        // Возвращаем общее количество вхождений элемента itemToCount в массиве items.
        return count;
    }

    public static void Main()
    {
        int[] numbers = { 5, 3, 7, 5, 2, 5, 9, 5 };
        int elementToCount = 5; // Элемент, который мы считаем.

        int count = GetElementCount(numbers, elementToCount);

        Console.WriteLine($"Количество вхождений элемента {elementToCount} в массиве: {count}");
    }
}