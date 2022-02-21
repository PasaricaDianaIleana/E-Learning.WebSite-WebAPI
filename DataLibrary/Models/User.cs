using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DataLibrary.Models
{
    public class User: IdentityUser
    {
        [Column(TypeName="nvarchar(50)")]
        public string FullName { get; set; }
    }
}
