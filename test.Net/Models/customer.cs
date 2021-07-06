using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test.Net.Models
{
    public class customer
    {
       
        public int customerID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string UserName { get; set; }

     

    }
}
