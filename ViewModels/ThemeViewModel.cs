using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Bomject1.ViewModels
{
    public class ThemeViewModel
    {
        [Display(Name = "Порядковый номер записи")]
        public int Id { get; set; }

        [Display(Name = "Тема дня")]
        public string Name { get; set; }

        [Display(Name = "Содержание темы")]
        public string Content { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
    }
}
