using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
	public class UserToRegisterDto
	{
		[Required]
		public string Username { get; set; }

		[Required]
		[StringLength(30, MinimumLength = 6, ErrorMessage = "The password must be at least 6 characters long (30 characters max).")]
		public string Password { get; set; }
	}
}
