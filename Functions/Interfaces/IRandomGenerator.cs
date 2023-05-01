using SwaggerDITest.Models;

namespace SwaggerDITest.Functions.Interfaces
{
    public interface IRandomGenerator
    {
        public List<int> GetRandomNumbers(RandomValues randomValues);
    }
}
