﻿using System.Diagnostics;
using SwaggerDITest.Models;
using SwaggerDITest.Algorythms.Interface;

namespace SwaggerDITest.Algorythms
{
    public class MergeSort : IMergeSort
    {
        public DataSetResponse Sort(List<int> array, int left, int right)
        {
            long time;
            Stopwatch watch = new Stopwatch();
            watch.Reset();
            watch.Start();
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }
            watch.Stop();
            time = watch.ElapsedTicks;
            DataSetResponse data = new DataSetResponse() { AlgorithmName = "Merge Sort", Sorted = array, TotalTime = time };
            return data;
        }
        public void MergeArray(List<int> array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j]; //tutaj jest outofrange

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
    }
}
