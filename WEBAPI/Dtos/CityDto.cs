using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Dtos
{
    public class CityDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Mandatory")]
        [StringLength(50,MinimumLength =2)]
        [RegularExpression(".*[A-Za-z]+.*",ErrorMessage ="only numeric not allowed")]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
