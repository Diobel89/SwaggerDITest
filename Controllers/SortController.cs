//using Microsoft.AspNetCore.Mvc;
//using SwaggerDITest.Algorythms.Interface;
//using SwaggerDITest.Models;

//namespace SwaggerDITest.Controllers
//{
//    [Route("/[controller]")]
//    [ApiController]
//    public class SortController : Controller
//    {
//        private readonly IBubbleSort? _bubbleSort;
//        private readonly IInsertionSort? _insertionSort;
//        private readonly IMergeSort? _mergeSort;
//        private readonly IQuickSort? _quickSort;
//        private readonly ISelectionSort? _selectionSort;
//        private readonly ITreeSort? _treeSort;

//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Bubble(InputDTO inputDTO)
//        {
//            OutputDTO data = _bubbleSort.Sort(inputDTO.Unsorted);
//            return data;
//        }
//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Insertion(InputDTO inputDTO)
//        {
//            OutputDTO data = _insertionSort.Sort(inputDTO.Unsorted);
//            return data;
//        }
//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Merge(InputDTO inputDTO)
//        {
//            OutputDTO data = _mergeSort.Sort(inputDTO.Unsorted, 0, inputDTO.Unsorted.Length);
//            return data;
//        }
//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Quick(InputDTO inputDTO)
//        {
//            OutputDTO data = _quickSort.Sort(inputDTO.Unsorted, 0, inputDTO.Unsorted.Length);
//            return data;
//        }
//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Selection(InputDTO inputDTO)
//        {
//            OutputDTO data = _selectionSort.Sort(inputDTO.Unsorted);
//            return data;
//        }
//        [HttpPost]
//        [Produces("application/json")]
//        public OutputDTO Tree(InputDTO inputDTO)
//        {
//            OutputDTO data = _treeSort.Sort(inputDTO.Unsorted);
//            return data;
//        }

//    }
//}
