using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms.Interface
{
    public interface IMergeSort
    {
        public OutputDTO Sort(int[] array, int left, int right);
    }
}