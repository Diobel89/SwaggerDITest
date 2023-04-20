using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class SelectionSortController : Controller
    {
        private readonly ISelectionSort _selectionSort;
        public SelectionSortController(ISelectionSort selectionSort)
        {
            _selectionSort = selectionSort;
        }

        /// <summary>
        /// Get InputDTO, use Selection Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/selection")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortBySelection([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _selectionSort.Sort(inputDTO.Unsorted);
            return View(response);
        }
    }
}
