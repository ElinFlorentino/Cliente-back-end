using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteBackEnd.Data.ViewModels
{
    public class ClienteVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
