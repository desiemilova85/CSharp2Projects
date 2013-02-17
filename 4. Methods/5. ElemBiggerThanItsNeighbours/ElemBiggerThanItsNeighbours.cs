using System;

    class ElemBiggerThanItsNeighbours
    {
        static void CheckBiggerNumber(int[] array, int position)
        {
            if (((position == 0) && (array[position] > array[position + 1])) ||
            ((position == array.Length - 1) && (array[position] > array[position - 1])) ||
            (array.Length == 1)||(((position > 0) && (position < array.Length - 1)) &&
            (array[position] > array[position + 1])&&
            (array[position] > array[position - 1])))
            {
                Console.WriteLine("The element {0} is bigger than its neighbours.", array[position]);
 
            }
            else
            {
                Console.WriteLine("The element {0} is not the biggest among its neighbours.", array[position]);
            }
        }
 
        static void Main()
        {
            Console.Write("Please enter the length of the array = ");
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            for (int j = 0; j < n; j++)
            {
                Console.Write("Array[{0}] = ", j);
                newArray[j] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please enter the position of the element which you would like to check: ");
            int index = int.Parse(Console.ReadLine());
            CheckBiggerNumber(newArray, index);
        }
    }
