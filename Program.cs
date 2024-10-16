namespace Sorting;
class Program
{
    static void Main(string[] args)
    {
        int[] data = { 8, 2, 7, 3, 10, 4, 6 };

        Console.WriteLine("Choose a sorting method:");
        Console.WriteLine("1: Selection Sort");
        Console.WriteLine("2: Insertion Sort");
        Console.WriteLine("3: Merge Sort");
        Console.Write("Enter your choice (1-3): ");

        string choice = Console.ReadLine();
        int[] sortedData = (int[])data.Clone(); 

        switch (choice)
        {
            case "1":
                SelectionSort(sortedData);
                Console.WriteLine("\nSorted using Selection Sort:");
                break;

            case "2":
                InsertionSort(sortedData);
                Console.WriteLine("\nSorted using Insertion Sort:");
                break;

            case "3":
                MergeSort(sortedData, 0, sortedData.Length - 1);
                Console.WriteLine("\nSorted using Merge Sort:");
                break;

            default:
                Console.WriteLine("Invalid choice. Exiting...");
                return;
        }

        PrintArray(sortedData);

    }

    static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (i=0; i < n-1; i++)
        {
            int minIndex = i;
            
            for(int j=i +1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
        int temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
}
