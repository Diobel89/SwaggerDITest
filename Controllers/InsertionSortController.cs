using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class InsertionSortController : Controller
    {
        private readonly IInsertionSort _insertionSort;
        public InsertionSortController(IInsertionSort insertionSort)
        {
            _insertionSort = insertionSort;
        }
        /// <summary>
        /// Get InputDTO, use Insertion Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/insertion")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortByInsertion([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _insertionSort.Sort(inputDTO.Unsorted);
            return View(response);
        }
    }
}
