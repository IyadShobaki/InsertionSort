using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // In-place algorithm
            // O(n^2) time complexity
            // Stable algorithm
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };

            // We consider that the first element in position 0 is in the sorted part
            // so we start from the second element position 1 and compare it to the previous element
            // if it smaller, we shift it.
            for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            {
                int newElement = intArray[firstUnsortedIndex];
                int i;
                for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--) 
                {
                    intArray[i] = intArray[i - 1];
                }
                intArray[i] = newElement;
            }


            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            //{
            //    int newElement = intArray[firstUnsortedIndex];
            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--) 
            //    {
            //        intArray[i] = intArray[i - 1];
            //    }
            //    intArray[i] = newElement;
            //}


            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            //{
            //    int newElement = intArray[firstUnsortedIndex];
            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--) 
            //    {
            //        intArray[i] = intArray[i - 1];
            //    }
            //    intArray[i] = newElement;
            //}



            //for (int firstUnsortedIndex = 1; firstUnsortedIndex < intArray.Length; firstUnsortedIndex++)
            //{
            //    int newElement = intArray[firstUnsortedIndex];

            //    int i;
            //    for (i = firstUnsortedIndex; i > 0 && intArray[i - 1] > newElement; i--) 
            //    {
            //        intArray[i] = intArray[i - 1];
            //    }
            //    intArray[i] = newElement;
            //}



            // Selection Sort from last lecture
            //for (int lastUnsortedIndex = intArray.Length -1; lastUnsortedIndex >0; lastUnsortedIndex--)
            //{
            //    int largestElementIndex = 0;
            //    for (int i = 1; i <= lastUnsortedIndex; i++)
            //    {
            //        if (intArray[i] > intArray[largestElementIndex])
            //        {
            //            largestElementIndex = i;
            //        }
            //    }
            //    swap(intArray, largestElementIndex, lastUnsortedIndex);
            //}

            Console.WriteLine(string.Join(" ", intArray));
            Console.ReadLine();

        }

        //public static void swap(int[] array, int i, int j)
        //{
        //    if (i == j)
        //    {
        //        return;
        //    }
        //    int temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}
    }
}
