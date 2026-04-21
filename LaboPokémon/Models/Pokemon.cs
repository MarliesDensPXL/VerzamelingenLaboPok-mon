using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboPokémon.Models
{
    public class Pokemon
    {
        public Pokemon(string name, string type, int level)
        {
            Name = name;
            Type = type;
            Level = level;
        }

        

        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }


        //1.9
        public override string? ToString() // om je pokemon-object op een goeie manier om te vormen naar een string.
        {
            // return base.ToString(); // zo wordt het 'basis' afgedrukt, maar dat willen we niet.
            return $"{this.Name} - {this.Type}"; // als je dit als tekst afdrukt, moet je deze waarden afdrukken.
        }

        //private string _name;

        //public string Name
        //{
        //	get { return _name; }
        //	set { _name = value; }
        //}

        //private int _level;

        //public int Level
        //{
        //	get { return _level; }
        //	set { _level = value; }
        //}

        //private string _type;

        //public string Type
        //{
        //	get { return _type; }
        //	set { _type = value; }
        //}




    }
}
