using Microsoft.AspNetCore.Mvc;
using SwaggerDITest.Algorythms.Interface;
using SwaggerDITest.Models;

namespace SwaggerDITest.Controllers
{
    public class TreeSortController : Controller
    {
        private readonly ITreeSort _treeSort;
        public TreeSortController(ITreeSort treeSort)
        {
            _treeSort = treeSort;
        }

        /// <summary>
        /// Get InputDTO, use Tree Sort Algorithm and returns OutputDTO
        /// </summary>
        /// <param name="inputDTO"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/tree")]
        [Produces("application/json")]
        public ActionResult<OutputDTO> SortByTree([FromBody] InputDTO inputDTO)
        {
            OutputDTO response = _treeSort.Sort(inputDTO.Unsorted);
            return View(response);
        }
    }
}
