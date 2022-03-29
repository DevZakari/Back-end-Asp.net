using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Oper_CRUD.Models
{
    public class Etudiant
    {
        [Key]
        public int etu_id { get; set; }

        [Required(ErrorMessage ="Enter LastName of Student")]
        [Display(Name ="Student LastName")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Enter FirstName of Student")]
        [Display(Name = "Student FirstName")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter Num Tele")]
        [Display(Name = "Tele")]
        public int tel { get; set; }
        [Required(ErrorMessage = "Enter Url Image")]
        [Display(Name = "Url Image")]
        public string url_Img { get; set; }

    }
}
