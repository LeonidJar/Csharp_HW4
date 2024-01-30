internal class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[10];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = new Random().Next(10);
            Console.Write(i + " ");
        }    
        Console.WriteLine();

        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine());
        int[] result = GetThreeNums(numArray, num);

        if (result != null)
            foreach (int i in result)
                Console.Write(i + " ");
        else Console.WriteLine("В массиве нет подходящих чисел");
    }

    public static int[] GetThreeNums(int[] array, int num)
    {
        int[] indexArray = new int[3];

        for (int i = 0; i < array.Length - 2; i++)
            for (int j = 1; j < array.Length - 1; j++)
                for (int k = 2; k < array.Length; k++)
                    if (array[i] + array[j] + array[k] == num && i != j && i != k && j != k)
                    {
                        indexArray[0] = array[i];
                        indexArray[1] = array[j];
                        indexArray[2] = array[k];
                        return indexArray;
                    }

        return null;
    }
}