namespace ShellSort
{
    public class Class1
    {
        int[] shellSort(int[] arr)
        {
            int length = arr.Length;

            for (int gap = length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < length; i += 1)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }

            return arr;
        }
    }
}