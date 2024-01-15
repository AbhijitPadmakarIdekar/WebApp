using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public  class User
    {
        [Key]
        public int UserID { get; set; }

        [RegularExpression("^[a-zA-Z0-9]+$", 
            ErrorMessage = "UserName must contain only digits & letters.")]
        [Required(ErrorMessage = "UserName is required!")]
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50, MinimumLength = 10, 
            ErrorMessage = "UserName must be in range 10 to 50 letters.")]
        public string? UserName { get; set;} = string.Empty;

        [RegularExpression("^[a-zA-Z0-9]+$",
            ErrorMessage = "UserName must contain only digits & letters.")]
        [Required(ErrorMessage = "Password is required!")]
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20, MinimumLength = 10,
            ErrorMessage = "Password must be in range 10 to 20 letters.")]
        public string? Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Inalid emaild address!")]
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50, MinimumLength = 10,
            ErrorMessage = "EmailAddress must be in range 10 to 50 letters.")]
        public string? EmailAddress { get; set; } = string.Empty;

    }
}
