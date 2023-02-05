using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tri_tabs.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        [Display(Name = "Название отдела")]
        [Required(ErrorMessage ="Имя не указано")]
        public string Name { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
