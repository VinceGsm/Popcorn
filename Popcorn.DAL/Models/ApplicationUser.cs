using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Popcorn.DAL.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]       
        public override Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }        
    }
}
