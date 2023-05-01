using SwaggerDITest.Functions.Interfaces;
using SwaggerDITest.Models;

namespace SwaggerDITest.Functions
{
    public class RandomGenerator : IRandomGenerator
    {
        public List<int> GetRandomNumbers(RandomValues randomValues)
        {
            var rand = new Random();
            List<int> temp = new List<int>();
            for (int index = 0; index < randomValues.Size; index++)
            {
                temp.Add(rand.Next(randomValues.Min, randomValues.Max));
            }
            return temp;
        }
    }
}
