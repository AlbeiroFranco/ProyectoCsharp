using Microsoft.AspNetCore.Identity;

namespace ProyectoCsharp.Data
{
    public class Empleado: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxtId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
