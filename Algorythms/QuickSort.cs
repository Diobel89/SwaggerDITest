﻿using System.Diagnostics;
using SwaggerDITest.Models;
using SwaggerDITest.Algorythms.Interface;

namespace SwaggerDITest.Algorythms
{
    public class QuickSort : IQuickSort
    {
        public OutputDTO Sort(int[] array, int leftIndex, int rightIndex)
        {
            long time;
            Stopwatch watch = new Stopwatch();
            watch.Reset();
            watch.Start();
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
                Sort(array, leftIndex, j);

            if (i < rightIndex)
                Sort(array, i, rightIndex);

            watch.Stop();
            time = watch.ElapsedTicks;

            OutputDTO data = new OutputDTO() { AlgorithmName = "Quick Sort", Sorted = array, TotalTime = time };
            return data;
        }
    }
}
