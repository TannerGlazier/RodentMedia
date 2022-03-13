using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RodentMedia.Models
{
    public class RatMedia
    {
        [Key]
        [Required]
        public int MediaId { get; set; }
        [Required(ErrorMessage ="Please enter the image URL for the media or the rat.")]
        public string Image { get; set; }
        [Required(ErrorMessage ="Please enter the name of the media.")]
        public string MediaName { get; set; }
        [Required(ErrorMessage ="If the rodent does not have a given name, simply put 'Rat'.")]
        public string RatName { get; set; }
        [Required(ErrorMessage ="Please enter the year that this instance of rat propaganda was put into circulation.")]
        public int Year { get; set; }
        [Required(ErrorMessage ="Please give a description of the role the rat plays in the media.")]
        public string Description { get; set; }        
        
        //Build Foreign Key Relationship
        [Required]
        public int MediaTypeId { get; set; }        
        [Required(ErrorMessage ="Please indicate the type of media.")]
        public MediaType MediaType { get; set; }
    }
}
