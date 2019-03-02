using ProjectManagment.DAL;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagment.Models
{
    public class UserProject :IEntity
    {
        [Required]
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int ProjectId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }

        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
    }
}