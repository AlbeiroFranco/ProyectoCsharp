using System.ComponentModel.DataAnnotations;

namespace ProyectoCsharp.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        public int DefaultDays { get; set; }

    }
}
