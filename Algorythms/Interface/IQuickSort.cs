using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms.Interface
{
    public interface IQuickSort
    {
        public DataSetResponse Sort(int[] array, int leftIndex, int rightIndex);
    }
}