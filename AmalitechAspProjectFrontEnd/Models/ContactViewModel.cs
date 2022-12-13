using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmalitechAspProjectFrontEnd.Models
{
    public class ContactViewModel
    {
        [Display(Name="Name")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAdress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [Display(Name ="Your Message")]
        public string YourMessage { get; set; }

    }
}
