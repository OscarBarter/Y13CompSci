using System;

namespace MergeSort
{
    class Program
    {

        private static void MergeSort(int[] array)
        {
            if (!(array.Length < 2))
            {
                int midpoint = (array.Length - 1) / 2;

                int[] left_half = new int[midpoint];
                Array.Copy(array, left_half, midpoint);

                int[] right_half = new int[array.Length - midpoint];
                Array.Copy(array, midpoint, right_half, 0, array.Length - midpoint);

                MergeSort(left_half);
                MergeSort(right_half);

                Merge(array, left_half, right_half);
            }
        }

        private static void Merge(int[] array, int[] left_half, int[] right_half)
        {
            int index_1 = 0;
            int index_2 = 0;
            int mergeIndex = 0;

            while (index_1 < left_half.Length && index_2 < right_half.Length)
            {
                if (left_half[index_1] < right_half[index_2])
                {
                    array[mergeIndex] = left_half[index_1];
                    index_1++;
                }
                else
                {
                    array[mergeIndex] = right_half[index_2];
                    index_2++;
                }

                mergeIndex++;
            }

            while (index_1 < left_half.Length)
            {
                array[mergeIndex] = left_half[index_1];
                index_1++;
                mergeIndex++;
            }

            while (index_2 < right_half.Length)
            {
                array[mergeIndex] = right_half[index_2];
                index_2++;
                mergeIndex++;
            }
        }

        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random random = new Random();
            // Fill with random numbers between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            // Reverse
            /*            for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = array.Length - i;
                        }*/

            // Sorted
            /*for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }*/


            int[] array2 = (int[])array.Clone();
            int[] array3 = (int[])array.Clone();
            int[] array4 = (int[])array.Clone();

            Print(array);

            Console.WriteLine("Bubble Sort: ");
            BubbleSort(array);
            Print(array);

            Console.WriteLine("Selection Sort: ");
            SelectionSort(array2);
            Print(array2);

            Console.WriteLine("Insertion Sort: ");
            InsertionSort(array3);
            Print(array3);

            Console.WriteLine("Merge Sort: ");
            InsertionSort(array4);
            Print(array4);

            Console.ReadLine();
        }
    }
}
