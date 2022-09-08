using System;
namespace WebApplication1
{
	public class SuperHero
	{
		public SuperHero()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
		public string City { get; set; } = string.Empty;

    }
}

