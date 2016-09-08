using Delegates_and_events.GradeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events
{
	class Program
	{
		public delegate void Writer(string message);

		static void Main()
		{
			#pragma warning disable RECS0026 // Possible unassigned object created by 'new'
			new Program();
			#pragma warning restore RECS0026 // Possible unassigned object created by 'new'
		}

		public Program() {
			var logger = new Logger();
			var writer = new Writer(logger.WriteMessage);
			#pragma warning disable RECS0021 // Warns about calls to virtual member functions occuring in the constructor
			writer("Succes");
			#pragma warning restore RECS0021 // Warns about calls to virtual member functions occuring in the constructor

			
			GradeBook();

			Console.ReadKey();
		}

		void GradeBook() {
			var book = new GradeBook.GradeBook();

			// using += to make sure we SUBSCRIBE to the delegate and not overwrite it :)
			// we can remove a method with -=
			#pragma warning disable RECS0164 // Explicit delegate creation expression is redundant
			book.NameChanged += new NameChangedDelegate(OnNameChanged);
			#pragma warning restore RECS0164 // Explicit delegate creation expression is redundant

			// we don't need new NameChangedDelegate
			book.NameChanged += OnNameChanged;

			book.Name = "testing";
			
		}

		void OnNameChanged(Object o, NameChangedEventArgs args)
		{
			Console.WriteLine("Grade book changing from {0} to {1}", args.ExistingName, args.NewName);
		}



	}
}
