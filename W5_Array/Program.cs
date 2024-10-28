public class Program
{
    public static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 2;
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.Write("Give another number for 11th element: ");
        int input = int.Parse(Console.ReadLine());

        // creating new array as old one cannot be expanded, and add input as last element
        int[] newNumbers = new int[numbers.Length + 1];
        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[i];
        }
        newNumbers[numbers.Length] = input;
        
        // sort the array in descending order
        Array.Sort(newNumbers);
        for (int i = newNumbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(newNumbers[i]);
        }

        Console.ReadKey();
    }
}