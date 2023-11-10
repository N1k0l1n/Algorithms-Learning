namespace BubbleSort
{
    public class Class1
    {
        static int[] bubleSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}