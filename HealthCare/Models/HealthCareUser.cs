using Microsoft.AspNetCore.Identity;

namespace HealthCare.Models
{
	public class HealthCareUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }
	}
}
