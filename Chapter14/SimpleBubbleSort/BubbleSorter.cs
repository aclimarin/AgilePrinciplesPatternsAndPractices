namespace SimpleBubbleSort
{
    public class BubbleSorter {
        private static int _operations;
        public static int Sort(int[] array){
            _operations = 0;
            if (array.Length <= 1)
                return _operations;

            for (int nextToLast = array.Length - 2
                    ; nextToLast >= 0
                    ; nextToLast--)
                        for (int index = 0; index <= nextToLast; index++)
                            CompareAndSwap(array, index);

            return _operations;
        }

        private static void CompareAndSwap(int[] array, int index)
        {
            if (array[index] > array[index+1])
                Swap(array, index);

            _operations++;
        }

        private static void Swap(int[] array, int index)
        {
            int temp = array[index];
            array[index] = array[index+1];
            array[index+1] = temp;
        }
    }
}