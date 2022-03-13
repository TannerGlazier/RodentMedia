using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodentMedia.Models
{
    public class MediaType
    {
        [Key]
        [Required]
        public int MediaTypeId { get; set; }
        public string MediaTypeName { get; set; }
    }
}
