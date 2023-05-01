using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Functions.Interfaces;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class RandomListController : Controller
    {
        private readonly IRandomGenerator _randomGenerator;
        public RandomListController(IRandomGenerator randomGenerator)
        {
            _randomGenerator = randomGenerator;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Generate(string AlgorithmName, RandomValues randomValues)
        {
            DataSetRequest request = new DataSetRequest();
            request.Unsorted = _randomGenerator.GetRandomNumbers(randomValues);
            request.Test = "null";
            if (AlgorithmName == "1")
            {
                return RedirectToAction("SortByBubble", "BubbleSort", request); // dziwnym trafem jeżeli funkcja zwraca liste a nie cały obiekt to jest ok :D
            }
            if (AlgorithmName == "2")
            {
                return RedirectToAction("SortByInsertion", "InsertionSort", request);
            }
            if (AlgorithmName == "3")
            {
                return RedirectToAction("SortByMerge", "MergeSort", request);
            }
            else
            {
                return View();
            }
        }
    }
}
