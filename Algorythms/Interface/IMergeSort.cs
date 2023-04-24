using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms.Interface
{
    public interface IMergeSort
    {
        public DataSetResponse Sort(int[] array, int left, int right);
    }
}