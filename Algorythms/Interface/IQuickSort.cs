using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms.Interface
{
    public interface IQuickSort
    {
        public OutputDTO Sort(int[] array, int leftIndex, int rightIndex);
    }
}