using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is a required field.")]
        [MaxLength(30,ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is a required field.")]
        [Range(16, 100, ErrorMessage = "Age must be at least 16 or less then 100.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Position is 30 characters.")]
        public string Position { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
