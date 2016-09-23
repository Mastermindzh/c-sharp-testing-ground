using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class message
    {
		public int MessageID { set; get; }
		public string Message { set; get; }
		public bool Processed { set; get; }
		public string Recipient_username { set; get; }

	}
}
