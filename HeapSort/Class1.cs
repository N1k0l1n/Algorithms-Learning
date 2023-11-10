namespace HeapSort
{
    public class Class1
    {
        public static int[] HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }

            return arr;
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        static void Swap(int[] arr, int element1, int element2)
        {
            int swap = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = swap;
        }
    }
}
