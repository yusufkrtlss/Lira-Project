using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dto
{
    public class CustomerUpdateDto
    {
        [DisplayName("Customer Full Name")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(100, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerFullName { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(50, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string Email { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(250, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(3, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerAddress { get; set; }

        [DisplayName("Customer Phone")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(13, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(11, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerPhone { get; set; }

        [DisplayName("Created Date")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(13, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(9, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CreatedDate { get; set; }

        [DisplayName("Customer Status")]
        [Required(ErrorMessage = "{0} it shouldn't be empty ! ")]
        [MaxLength(5, ErrorMessage = "{0} it cannot be greater than {1} ")]
        [MinLength(4, ErrorMessage = "{0} it cannot be lower than {1}")]
        public string CustomerStatus { get; set; }
    }
}
