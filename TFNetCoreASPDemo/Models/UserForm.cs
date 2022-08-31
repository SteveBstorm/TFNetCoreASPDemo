using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFNetCoreASPDemo.Models
{
    public class UserForm
    {

        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MinLength(5)]
        public string Nickname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare(nameof(Password), ErrorMessage ="Les deux champs mdp doivent correspondre")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
