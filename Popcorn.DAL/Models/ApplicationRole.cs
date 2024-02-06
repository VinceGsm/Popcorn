using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Popcorn.DAL.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole() : base()
        { }

        public ApplicationRole(string roleName) : base(roleName)
        { }

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
