using System;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set; }

        [Required (ErrorMessage ="Kinda Need to know who you are")]
        public string FirstName {get; set; }

        [Required(ErrorMessage="Come on now... Whats your Last Name Sweety")]
        public string LastName {get; set; }

        [Required(ErrorMessage="In case you didn't realize, this helps us Identify you, Dear.")]
        public string Email {get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You are required to have a password, Goober")]
        [MinLength(8, ErrorMessage = "That's not long enough... Gotta be 8 Characters or higher, silly goose")]
        public string Password {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="This is ALSO required")]
        public string Comfirm {get; set;}

        // Dont forget to make and run migrations AKA  
        // dotnet ef migrations add MigrationNameHere
        // dotnet ef database update
    }
}