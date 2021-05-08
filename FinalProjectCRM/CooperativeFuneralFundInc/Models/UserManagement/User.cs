using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CooperativeFuneralFundInc.Models.UserManagement
{
    public class User:IdentityUser
    {
        // Inherits all IdentityUser properties
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
