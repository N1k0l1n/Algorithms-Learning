namespace InsertionSort
{
    public class Class1
    {
        static int[] insertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];
                for (int j = i - 1; j > -1 && arr[i] > value; j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[i + 1] = value;
            }
            return arr;
        }
    }
}