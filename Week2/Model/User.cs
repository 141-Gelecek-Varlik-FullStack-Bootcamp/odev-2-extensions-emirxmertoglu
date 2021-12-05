using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : IUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adinizi giriniz!")]
        [MaxLength(100, ErrorMessage = "Adiniz max 100 karakter olabilir!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email adresinizi giriniz!")]
        [EmailAddress(ErrorMessage = "Gecerli bir mail adresi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sifrenizi giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Kullanici rolunuzu giriniz!")]
        public string Role { get; set; }
    }
}
