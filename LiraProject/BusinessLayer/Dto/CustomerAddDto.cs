using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dto
{
    public class CustomerAddDto
    {
        // Buradaki kullandığımız CustomerFull name gördüğün gibi entity de de var
        [DisplayName("Customer First Name")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(100, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerFirstName { get; set; }

        [DisplayName("Customer Last Name")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(100, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerLastName { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(50, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string Email { get; set; }

        [DisplayName("Customer Phone")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(15, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(12, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerPhone { get; set; }

        [DisplayName("Customer Phone")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(50, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(9, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerPassword { get; set; }


    }
}
