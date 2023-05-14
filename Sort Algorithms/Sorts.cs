namespace Sort_Algorithms
{
    public class Sorts
    {
        public Sorts() { NumArray = new int[] { 0 }; }

        public int[] NumArray { get; set; }

        public int[] BubbleSort()
        {
            var n = NumArray.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (NumArray[j] > NumArray[j + 1])
                    {
                        var tempVar = NumArray[j];
                        NumArray[j] = NumArray[j + 1];
                        NumArray[j + 1] = tempVar;
                    }
            return NumArray;
        }

        public int[] SelectionSort()
        {
            var arrayLength = NumArray.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (NumArray[j] < NumArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = NumArray[smallestVal];
                NumArray[smallestVal] = NumArray[i];
                NumArray[i] = tempVar;
            }
            return NumArray;
        }

        public int[] InsertionSort()
        {
            var arrayLength = NumArray.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                var key = NumArray[i];

                for (int j = i - 1; ;)
                {
                    if (key < NumArray[j])
                    {
                        NumArray[j + 1] = NumArray[j];
                        j--;
                        NumArray[j + 1] = key;
                    }
                    else break;
                }
            }

            return NumArray;
        }

        public int[] MergeSort()
        {
            return MergeSort(NumArray, 0, NumArray.Length - 1);
        }

        public int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (right + left) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        public int[] QuickSort()
        {
            return QuickSort(NumArray, 0, NumArray.Length - 1);
        }

        public int[] QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);

            if (i < rightIndex)
                QuickSort(array, i, rightIndex);

            return array;
        }

        public int[] ShellSort()
        {
            var arrayLength = this.NumArray.Length;
            for (int interval = arrayLength / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < arrayLength; i++)
                {
                    var currentKey = NumArray[i];
                    var k = i;

                    while (k >= interval && NumArray[k - interval] > currentKey)
                    {
                        NumArray[k] = NumArray[k - interval];
                        k -= interval;
                    }

                    NumArray[k] = currentKey;
                }
            }

            return NumArray;
        }

        public static int GetMaxVal(int[] array, int size)
        {
            var maxVal = array[0];

            for (int i = 1; i < size; i++)
                if (array[i] > maxVal)
                    maxVal = array[i];

            return maxVal;
        }

        public int[] CountingSort()
        {
            var size = NumArray.Length;
            var maxElement = GetMaxVal(NumArray, size);
            var occurrences = new int[maxElement + 1];

            for (int i = 0; i < maxElement + 1; i++)
            {
                occurrences[i] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                occurrences[NumArray[i]]++;
            }

            for (int i = 0, j = 0; i <= maxElement; i++)
            {
                while (occurrences[i] > 0)
                {
                    NumArray[j] = i;
                    j++;
                    occurrences[i]--;
                }
            }

            return NumArray;
        }

        public int[] RadixSort()
        {
            var arrayLength = this.NumArray.Length;
            var maxVal = GetMaxVal(NumArray, arrayLength);

            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
                Counting(NumArray, arrayLength, exponent);

            return NumArray;
        }

        public static void Counting(int[] array, int size, int exponent)
        {
            var outputArr = new int[size];
            var occurences = new int[10];

            for (int i = 0; i < 10; i++)
                occurences[i] = 0;

            for (int i = 0; i < size; i++)
                occurences[(array[i] / exponent) % 10]++;

            for (int i = 1; i < 10; i++)
                occurences[i] += occurences[i - 1];

            for (int i = size - 1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }

            for (int i = 0; i < size; i++)
                array[i] = outputArr[i];
        }

        public int[] BucketSort()
        {
            if (NumArray == null || NumArray.Length <= 1)
            {
                return NumArray;
            }

            int maxValue = NumArray[0];
            int minValue = NumArray[0];

            for (int i = 1; i < NumArray.Length; i++)
            {
                if (NumArray[i] > maxValue)
                {
                    maxValue = NumArray[i];
                }

                if (NumArray[i] < minValue)
                {
                    minValue = NumArray[i];
                }
            }

            LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

            for (int i = 0; i < NumArray.Length; i++)
            {
                if (bucket[NumArray[i] - minValue] == null)
                {
                    bucket[NumArray[i] - minValue] = new LinkedList<int>();
                }

                bucket[NumArray[i] - minValue].AddLast(NumArray[i]);
            }

            var index = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<int> node = bucket[i].First;

                    while (node != null)
                    {
                        NumArray[index] = node.Value;
                        node = node.Next;
                        index++;
                    }
                }
            }

            return NumArray;
        }

        public int[] HeapSort()
        {
            var arrayLength = NumArray.Length;
            if (arrayLength <= 1)
                return NumArray;

            for (int i = arrayLength / 2 - 1; i >= 0; i--)
            {
                Heapify(NumArray, arrayLength, i);
            }

            for (int i = arrayLength - 1; i >= 0; i--)
            {
                var tempVar = NumArray[0];
                NumArray[0] = NumArray[i];
                NumArray[i] = tempVar;

                Heapify(NumArray, i, 0);
            }

            return NumArray;
        }

        static void Heapify(int[] array, int size, int index)
        {
            var largestIndex = index;
            var leftChild = 2 * index + 1;
            var rightChild = 2 * index + 2;

            if (leftChild < size && array[leftChild] > array[largestIndex])
            {
                largestIndex = leftChild;
            }

            if (rightChild < size && array[rightChild] > array[largestIndex])
            {
                largestIndex = rightChild;
            }

            if (largestIndex != index)
            {
                var tempVar = array[index];
                array[index] = array[largestIndex];
                array[largestIndex] = tempVar;

                Heapify(array, size, largestIndex);
            }
        }
    }
}