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

        // resizing the array, and add input as last element
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = input;
        
        // sort the array in descending order
        Array.Sort(numbers);
        Array.Reverse(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.ReadKey();
    }
}