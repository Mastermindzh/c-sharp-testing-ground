using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.example2
{
	class example2
	{
		Employee[] developers =
		{
			new Employee { Id = 1, Name = "Scott" },
			new Employee { Id = 1, Name = "Chris" }
		};

		List<Employee> sales = new List<Employee>()
		{
			new Employee{ Id = 3, Name = "Alex"}
		};

		public example2()
		{
			Console.WriteLine(sales.Count());

			foreach (var employee in developers.Where(
					e => e.Name.StartsWith("S", StringComparison.CurrentCulture)))
			{
				Console.WriteLine(employee.Name);
			}

			Console.ReadKey();
		}

	}
}
