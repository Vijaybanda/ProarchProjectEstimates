using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proarch.Project.Estimates.Models
{
    public class ModuleModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Name is required.")]
        public string Description { get; set; }

        //[Required(ErrorMessage = "Name is required.")]
        public string Status { get; set; }
    }
}
