using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void MergeSort(int[] array)
        {
            if(array.Length == 1)
            {
                return;
            }
            else
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

        static void Merge(int[] merged, int[] list1, int[] list2)
        {
            int index1 = 0;
            int index2 = 0;
            int index_merged = 0;

            while(index1<list1.Length && index2 < list2.Length)
            {
                if(list1[index1] < list2[index2])
                {
                    merged[index_merged] = list1[index1];
                    index1++;
                }
                else
                {
                    merged[index_merged] = list2[index2];
                    index2++;
                }
                index_merged++;
            }

            while(index1 < list1.Length)
            {
                merged[index_merged] = list1[index1];
                index1++;
                index_merged++;
            }

            while (index2 < list2.Length)
            {
                merged[index_merged] = list2[index2];
                index2++;
                index_merged++;
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < n- i -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            } 
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[i], ref array[min]);
            }
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i <= n - 1; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }

        static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
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
            int[] array = new int[2];
            Random random = new Random();
            // Fill with random numbers between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(30);
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

            /*
            int[] array2 = (int[]) array.Clone();
            int[] array3 = (int[]) array.Clone();

            //            Print(array);
            Console.WriteLine("Bubble Sort: ");
            BubbleSort(array);
            //            Print(array);
            Console.WriteLine("Selection Sort: ");
            SelectionSort(array2);
            //           Print(array2);
            Console.WriteLine("Insertion Sort: ");
            InsertionSort(array3);
            //           Print(array3);
            Console.ReadLine();
            */
            Print(array);
            Console.WriteLine("Merge Sort: ");
            MergeSort(array);
            Print(array);
            Console.ReadLine();
        }


    }
}
