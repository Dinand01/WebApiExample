using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Requests
{
    public class CustomerRequest
    {
        [Range(0, 9999999999, ErrorMessage = "Invalid Customer ID")]
        public long? CustomerID { get; set; }

        [StringLength(25, ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
