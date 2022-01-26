using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Remove(ref int[] array, int index)
            {
                int[] newArray = new int[array.Length - 1];

                for (int i = 0; i < index; i++) 
                {
                    newArray[i] = array[i];
                }
                for (int i = index + 1; i < array.Length; i++)
                {
                    newArray[i - 1] = array[i];
                }
                array = newArray;

            }
            
     
            int[] array = {1, 11, 15, 3, 4, 5, 1, 5, 10, 9,10};

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Remove(ref array, i);
                        Remove(ref array, i);
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
