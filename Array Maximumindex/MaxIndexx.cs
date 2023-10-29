public class MaxIndexx
{
    public static int MaxIndex(double[] array)
    {
        // Инициализируем переменную max значением, которое гарантированно меньше всех элементов массива.
        var max = double.MinValue;
        
        // Проходимся по элементам массива, чтобы найти максимальное значение.
        foreach (var item in array)
            if (item > max) max = item; // Если текущий элемент больше текущего max, обновляем max.
	
        
        int index = -1;
        // Проверяем, если массив пустой, то возвращаем -1 (максимум не найден)
        if (array.Length == 0)
            return index;

        // Используем метод Array.IndexOf для нахождения индекса элемента с максимальным значением в массиве.
        index = Array.IndexOf(array, max);
        return index;
    }

    public static void Main()
    {
        double[] numbers = { 10.5, 3.2, 7.1, 15.6, 2.7, 20.3 };
        int maxIndex = MaxIndex(numbers);
        Console.WriteLine($"Индекс максимального значения: {maxIndex}");
    }
}