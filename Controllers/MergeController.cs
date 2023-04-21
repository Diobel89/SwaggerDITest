using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class MergeController : Controller
    {
        private readonly IMergeSort _mergeSort;

        public MergeController(IMergeSort mergeSort)
        {
            _mergeSort = mergeSort;
        }

        /// <summary>
        /// Get InputDTO, use Merge Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/merge")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortByMerge([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _mergeSort.Sort(inputDTO.Unsorted, 0, inputDTO.Unsorted.Length);
            return response;
        }
    }
}
