using ProjectManagment.DAL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagment.Models
{
    public class User : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50), Column(TypeName = "VARCHAR")]
        public string FirstName { get; set; }
        [Required, StringLength(50), Column(TypeName = "VARCHAR")]
        public string LastName { get; set; }
    }
}