using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
using System;
using System.Linq;
using System.Reflection;

namespace NHibernateDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var cfg = new Configuration();
			cfg.DataBaseIntegration(x =>
			{
				x.ConnectionString = "Server=.\\SQLEXPRESS;Database=NHibernateDemo;User=sa;Password=Welkom01!";
				x.Driver<SqlClientDriver>();
				x.Dialect<MsSql2012Dialect>();
			});

			cfg.AddAssembly(Assembly.GetExecutingAssembly());
			var sessionFactory = cfg.BuildSessionFactory();

			using (var session = sessionFactory.OpenSession())
			using (var tx = session.BeginTransaction())
			{
				var customers = session.Query<Customer>().ToArray();
				//var customers = from customer in session.Query<Customer>().ToArray()
				//				select customer;

				Console.WriteLine(customers.Length);
				foreach (var customer in customers)
				{
					Console.WriteLine(customer.FirstName);
					//Console.WriteLine("{0}, {1}", customer.FirstName, customer.LastName);
				}

				tx.Commit();


			}

			Console.ReadLine();
		}
	}
}
