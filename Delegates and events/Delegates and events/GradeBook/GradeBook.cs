using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events.GradeBook
{
	public class GradeBook
	{
		string name = "Empty";
		List<float> grades = new List<float>();
		public event NameChangedDelegate NameChanged;


		public void addGrade(float f)
		{
			grades.Add(f);
		}

		public string Name
		{
			get {
				return name;
			}
			set {
				if (!String.IsNullOrEmpty(value))
				{
					if(name != value)
					{
						NameChanged(this,new NameChangedEventArgs { ExistingName = name, NewName = value});
					}
					name = value;
				}
			}
		}
		
	}
}
