using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WitSite.Models
{
    public class ClientInfo
    {
        [Required]
        [Display(Name = "Ваш Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Ваш мобильный номер")]
        public string Tel { get; set; }
        [Required]
        [Display(Name = "Ваше имя")]
        public string Name { get; set; }
    }
}
