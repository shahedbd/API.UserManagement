using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Data.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
