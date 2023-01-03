using System.ComponentModel.DataAnnotations;

namespace ProyectoCsharp.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave type name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please enter a valid number")]
        public int Days { get; set; }

    }
}
