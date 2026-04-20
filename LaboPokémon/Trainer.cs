using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboPokémon
{
    public class Trainer
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private Pokemon[] _pokemon;

		public Pokemon[] Pokemon
		{
			get { return _pokemon; }
			set { _pokemon = value; }
		}



	}
}
