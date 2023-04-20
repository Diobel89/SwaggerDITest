using System.Diagnostics;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms
{
    public class BubbleSort : IBubbleSort
    {
        public OutputDTO Sort(int[]? array)
        {
            long time;
            Stopwatch watch = new Stopwatch();
            watch.Reset();
            watch.Start();
            var n = array.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        var tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                    }
            watch.Stop();
            time = watch.ElapsedTicks;
            OutputDTO data = new OutputDTO() { AlgorithmName = "Bubble Sort", Sorted = array, TotalTime = time };
            return data;
        }
    }
}
