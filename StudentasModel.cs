using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuSarasas
{
	public class StudentasModel
	{
		public int Id { get; set; }
		public string vardas { get; set; }
		public string pavarde { get; set; }
		public string nuotrauka { get; set; }
		public string pilnasVardas
		{
			get
			{
				return $"{vardas} {pavarde}";
			}
		}

	}
}
