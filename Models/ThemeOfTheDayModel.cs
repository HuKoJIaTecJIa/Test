using System.ComponentModel.DataAnnotations;
using System;
namespace Project_Bomject1.Models
{
    public class ThemeOfTheDayModel
    {
        [Key]
        public int ThemeOfTheDayId { get; set; }

        [Display(Name = "Тема дня")]
        [MaxLength (9)] 
        public string Name { get; set; }

        [Display(Name = "Содержание темы")]
        public string Content { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Display(Name = "Дата")]
       
        public DateTime Date { get; set; }
    }
}
