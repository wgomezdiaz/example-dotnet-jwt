using System;
namespace WebApplication1
{
	public class User
	{
        public string Usermane { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; } 

    }
}

