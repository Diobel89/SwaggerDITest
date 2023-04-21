using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class QuickSortController : Controller
    {
        private readonly IQuickSort _quickSort;
        public QuickSortController(IQuickSort quickSort)
        {
            _quickSort = quickSort;
        }

        /// <summary>
        /// Get InputDTO, use Quick Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/quick")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortByQuick([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _quickSort.Sort(inputDTO.Unsorted, 0, inputDTO.Unsorted.Length);
            return response;
        }
    }
}
