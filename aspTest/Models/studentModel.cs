using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspTest.Models
{
    public class studentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field Required!")]
        public string Class { get; set; }
        
    }
}
