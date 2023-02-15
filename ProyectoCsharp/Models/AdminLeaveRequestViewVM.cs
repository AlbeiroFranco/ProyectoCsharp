using System.ComponentModel.DataAnnotations;

namespace ProyectoCsharp.Models
{
    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total numbers of request")]
        public int TotalRequest { get; set; }

        [Display(Name = "Aprove request")]
        public int AprovedRequests { get; set; }

        [Display(Name = "Pending request")]
        public int PendingRequest { get; set; }

        [Display(Name = "Rejected request")]
        public int RejectedRequest { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }


    }
}
