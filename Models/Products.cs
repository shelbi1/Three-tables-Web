using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tri_tabs.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        [Display(Name = "Названия")]
        [Required(ErrorMessage = "Название не указано")]
        public string Name { get; set; }
        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Стоимость не указана")]
        public double Price { get; set; }
        [Display(Name = "Сотрудник")]
        [Required(ErrorMessage = "Сотрудник не указан")]

        public int EmployeeId { get; set; }
        
        public virtual Employees Employee { get; set; }
    }
}
