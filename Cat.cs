using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_1210
{
    internal class Cat
    {
        /// <summary>
        /// 
        /// </summary>

        public Guid Guid { get; set; }
        public string Species { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Pattern { get; set; }
        public string? Color { get; set; }
        public bool Sex { get; set; }

        public override string ToString()
        {
            return $"{Name} is a {(Color == null || Pattern == null ? "unknown" : $"{Pattern} {Color}")} {Species} cat, {BirthDate} years old {(Sex ? "male" : "female")}.";
        }

        public Cat(string name, DateTime birthDate, string? pattern, string? color, bool sex, string species)
        {
            Guid = Guid.NewGuid();
            Species = species ?? throw new ArgumentNullException(nameof(species));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = birthDate;
            Pattern = pattern;
            Color = color;
            Sex = sex;
        }

        public Cat(string name, DateTime birthDate, bool sex, string species, string? pattern = null, string? color = null) : this(name,birthDate,pattern, color, sex, "domestic") 
        {

        }
        
    }
}
