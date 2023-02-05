using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tri_tabs.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "ФИО не указано")]
        public string Fio { get; set; }
        [Display(Name = "Специальность")]
        [Required(ErrorMessage = "Специальность не указана")]
        public string Prophesy { get; set; }
        [Display(Name = "Отдел")]
        [Required(ErrorMessage = "Отдел не указан")]
        public int DepartmentId { get; set; }   
        public virtual Departments Department { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
