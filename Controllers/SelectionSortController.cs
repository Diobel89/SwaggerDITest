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
        public ActionResult<DataSetResponse> SortBySelection([FromBody] DataSetRequest inputDTO)
        {
            DataSetResponse response = _selectionSort.Sort(inputDTO.Unsorted);
            return response;
        }
    }
}
