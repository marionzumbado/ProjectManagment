using ProjectManagment.DAL;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagment.Models
{
    public class Project : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}