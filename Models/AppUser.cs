using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

public class AppUser : IdentityUser{
        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string HomeAddress {set;get;}
}