using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp2WebApi
{
    class Employee //We copied this from the employee class from the PoWebApi project nd brought over
    {
        public int Id { get; set; } 
        [Required, StringLength(30)]
        public string Login { get; set; }
        [Required, StringLength(30)]
        public string Password { get; set; }
        [Required, StringLength(30)]
        public string Firstname { get; set; }
        [Required, StringLength(30)]
        public string Lastname { get; set; }
        [Required]
        public bool IsManager { get; set; } 

        public Employee() { }
    }
}
