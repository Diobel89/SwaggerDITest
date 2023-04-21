using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class BubbleSortController : Controller
    {
        private readonly IBubbleSort _bubbleSort;
        public BubbleSortController(IBubbleSort bubbleSort) 
        {
            _bubbleSort = bubbleSort;
        }
        /// <summary>
        /// Get InputDTO, use Bubble Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/bubble")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortByBubble([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _bubbleSort.Sort(inputDTO.Unsorted);
            return response;
        }
        //[Produces("application/json")]
        //public OutputDTO Bubble(InputDTO inputDTO)
        //{
        //    OutputDTO data = _bubbleSort.Sort(inputDTO.Unsorted);
        //    return data;
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
