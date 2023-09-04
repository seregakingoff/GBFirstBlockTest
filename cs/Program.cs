using MyLib;

namespace FinalTestOnTheMainBlock;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array size: ");
        string[] sourceStrings = new string[MyLibClass.Propmt()];

        for (int i = 0; i < sourceStrings.Length; i++)
        {
            sourceStrings[i] = MyLibClass.Propmt($"Enter {i + 1} string: ");
        }

        string[] destinationArray = GetDstArray(sourceStrings);

        MyLibClass.PrintArray(destinationArray);
    }

    public static string[] GetDstArray(string[] srcArray)
    {
        int size = 0;
        for (int i = 0; i < srcArray.Length; i++)
        {
            if (srcArray[i].Length <= 3)
            {
                size++;
            }
        }
        string[] dstArray = new string[size];
        for (int i = 0, j = 0; i < srcArray.Length; i++)
        {
            if (srcArray[i].Length <= 3)
            {
                dstArray[j] = srcArray[i];
                j++;
            }
        }

        return dstArray;
    }
}