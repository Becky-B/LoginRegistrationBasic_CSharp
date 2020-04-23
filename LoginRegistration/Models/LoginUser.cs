using System;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="You gotta give me your email, Dear")]
        public string LoginEmail {get; set;}

        [Required(ErrorMessage="I need that Password, Hun")]
        public string LoginPassword {get; set; }

    }
}