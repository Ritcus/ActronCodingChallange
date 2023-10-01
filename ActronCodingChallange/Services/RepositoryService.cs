
using ActronCodingChallange.Interfaces;

namespace ActronCodingChallange.Services
{
    public class RepositoryService : IRepository
    {
        public string LargestNumberFormation(int[] array)
        {
            return MergeSortAlgorithm(array);
        }

        //This technique would be slow in terms of time complexity.
        public string SelectionSortAlgorithm(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var ij = array[i].ToString() + array[j].ToString();
                    var ji = array[j].ToString() + array[i].ToString();

                    if (Convert.ToInt32(ij) < Convert.ToInt32(ji))
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return string.Join("", array);
        }

        //Much better approach in terms of time complexity.
        public string MergeSortAlgorithm(int[] array)
        {
            int leftindex = 0;
            int rightindex = array.Length - 1;
            MergeSort(array, leftindex, rightindex);
            return string.Join("", array);
        }

        private void MergeSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int midIndex = (leftIndex + rightIndex) / 2;
                MergeSort(array, leftIndex, midIndex);
                MergeSort(array, midIndex + 1, rightIndex);
                Merge(array, leftIndex, midIndex, rightIndex);
            }
        }

        private void Merge(int[] array, int leftIndex, int midIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = midIndex + 1;
            int k = leftIndex;

            int[] tempArray = new int[rightIndex + 1];


            while (i <= midIndex && j <= rightIndex)
            {
                var ij = array[i].ToString() + array[j].ToString();
                var ji = array[j].ToString() + array[i].ToString();

                //Checking the combination of respective numbers to find the largest combination of those numbers and sorting them in  order.
                if (Convert.ToInt32(ij) > Convert.ToInt32(ji))
                {
                    tempArray[k] = array[i];
                    i++;
                    k++;
                }
                else
                {
                    tempArray[k] = array[j];
                    j++;
                    k++;
                }
            }

            while (i <= midIndex)
            {
                tempArray[k] = array[i];
                i++;
                k++;
            }

            while (j <= rightIndex)
            {
                tempArray[k] = array[j];
                j++;
                k++;
            }

            for (int x = leftIndex; x < rightIndex + 1; x++)
            {
                array[x] = tempArray[x];
            }

        }
    }
}
