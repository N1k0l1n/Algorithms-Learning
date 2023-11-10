namespace SelectionSort
{
    public class Class1
    {
        static int[] selectionSort(int[] arr)
        {
            int lenght = arr.Length;
            for (int i = 0; i < lenght; i++)
            {
                int minIndex = i;
                for (int j = 0; j < lenght; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //swaping the min element found
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

            }
            return arr;
        }
    }
}