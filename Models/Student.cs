using System.ComponentModel.DataAnnotations;
namespace MVCproject.Models
{
    public class Student
    {
        [Required(ErrorMessage="İsminizi giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email adresinizi giriniz")]
        [EmailAddress(ErrorMessage="Email adresinizi düzgün giriniz.")]
        public string Email { get; set; }
         [Required(ErrorMessage="Telefonunuzu giriniz")]
        public string Phone { get; set; }
       [Required(ErrorMessage="Katılma durumunuz nedir? ")]
        public bool? Confirm { get; set; } // true, false, null
    }

}