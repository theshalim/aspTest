using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspTest.Models
{
    public class TeacherModel
    {
        public int? Id { get; set; }
        public  studentModel student { get; set; }
        [Required(ErrorMessage ="This Field Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field Required!")]
        public string Designation { get; set; }
        public DateTime Joining { get; set; }
    }
}
