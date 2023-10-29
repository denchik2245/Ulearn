public class sabArr
{
    public static bool ContainsAtIndex(int[] array, int[] subArray, int k)
    {
        // Проходим по элементам подмассива subArray.
        for (int i = 0; i < subArray.Length; i++)
        {
            // Проверяем, если элемент в основном массиве array с индексом k + i не совпадает с элементом подмассива.
            if (array[k + i] != subArray[i])
            {
                // Если хотя бы один элемент не совпадает, возвращаем false.
                return false;
            }
        }
        
        // Если все элементы подмассива совпадают с соответствующими элементами основного массива, возвращаем true.
        return true;
    }

    public static void Main()
    {
        int[] mainArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] subArray1 = { 2, 3, 4 };
        int[] subArray2 = { 5, 6, 7 };
        int k1 = 1; // Индекс начала subArray1 в mainArray.
        int k2 = 4; // Индекс начала subArray2 в mainArray.

        bool contains1 = ContainsAtIndex(mainArray, subArray1, k1);
        bool contains2 = ContainsAtIndex(mainArray, subArray2, k2);

        Console.WriteLine($"subArray1 содержится в mainArray с индекса {k1}: {contains1}");
        Console.WriteLine($"subArray2 содержится в mainArray с индекса {k2}: {contains2}");
    }
}