using System.ComponentModel.DataAnnotations;

namespace SwaggerDITest.Models
{
    public class RandomValues
    {
        [Range(0, 99999, ErrorMessage = "Can only be beetween 0-99999")]
        public int Min { get; set; }
        [Range(0, 99999, ErrorMessage = "Can only be beetween 0-99999")]
        public int Max { get; set; }
        [Range(0, 99999, ErrorMessage = "Can only be beetween 0-99999")]
        public int Size { get; set; }
    }
}
