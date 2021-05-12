using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativeFuneralFundInc.Models.UserManagement
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter a email.")]
        [StringLength(255)]
        public string email { get; set; }


        [Required(ErrorMessage = "Please enter a firstName.")]
        [StringLength(255)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please enter a lastName.")]
        [StringLength(255)]
        public string lastName { get; set; }

    }
}
