public class ArrayOperations
{
   
    public static int[] GetAllIntegers(int[] array)
    {
        return array;
    }

  
    public static int[] GetEvenIntegers(int[] array)
    {
        return array.Where(x => x % 2 == 0).ToArray();
    }

    public static int[] GetOddIntegers(int[] array)
    {
        return array.Where(x => x % 2 != 0).ToArray();
    }

  
    public static int[] GetValuesGreaterThan(int[] array, int threshold)
    {
        return array.Where(x => x > threshold).ToArray();
    }

  
    public static int[] GetNumbersInRange(int[] array, int min, int max)
    {
        return array.Where(x => x >= min && x <= max).ToArray();
    }

 
    public static int[] GetMultiplesOfSeven(int[] array)
    {
        return array.Where(x => x % 7 == 0).OrderBy(x => x).ToArray();
    }

  
    public static int[] GetMultiplesOfEightDescending(int[] array)
    {
        return array.Where(x => x % 8 == 0).OrderByDescending(x => x).ToArray();
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 18, 21, 24, 28, 32 };

        Console.WriteLine("Усі цілі числа:");
        Console.WriteLine(string.Join(", ", GetAllIntegers(numbers)));

        Console.WriteLine("\nПарні цілі числа:");
        Console.WriteLine(string.Join(", ", GetEvenIntegers(numbers)));

        Console.WriteLine("\nНепарні цілі числа:");
        Console.WriteLine(string.Join(", ", GetOddIntegers(numbers)));

        Console.WriteLine("\nЗначення більше 10:");
        Console.WriteLine(string.Join(", ", GetValuesGreaterThan(numbers, 10)));

        Console.WriteLine("\nЧисла в діапазоні від 5 до 20:");
        Console.WriteLine(string.Join(", ", GetNumbersInRange(numbers, 5, 20)));

        Console.WriteLine("\nЧисла, кратні семи:");
        Console.WriteLine(string.Join(", ", GetMultiplesOfSeven(numbers)));

        Console.WriteLine("\nЧисла, кратні восьми (за спаданням):");
        Console.WriteLine(string.Join(", ", GetMultiplesOfEightDescending(numbers)));
    }
}