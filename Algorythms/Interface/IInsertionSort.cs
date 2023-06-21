using SwaggerDITest.Models;

namespace SwaggerDITest.Algorythms.Interface
{
    public interface IInsertionSort
    {
        public DataSetResponse Sort(List<int> array);
    }
}