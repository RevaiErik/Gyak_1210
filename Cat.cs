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
        /// GUID (Globally Unified Indentifi) a macska egyedi azonosítója
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// a macska alfaja
        /// </summary>
        public string Species { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Pattern { get; set; }
        public string? Color { get; set; }
        public bool Sex { get; set; }

        public override string ToString()
        {
            string patColStr = Color is null || Pattern is null ?
                "unknown color" : $"{Pattern} {Color}";

            return $"{Name} is a {patColStr} {Species} cat, {(Sex ? "he" : "she")} " +
                $"is {DateTime.Now.Year - BirthDate.Year} years old.";
        }

        /// <summary>
        /// a macswka példányosításáért felelő függvény
        /// </summary>
        /// <param name="name">a macska nevét tartalmazó string</param>
        /// <param name="birthDate">a macska születési dátuma "yyyy-MM-dd" formátumban</param>
        /// <param name="pattern">a macska mintázata</param>
        /// <param name="color"></param>
        /// <param name="sex"></param>
        /// <param name="species"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Cat(string name, string birthDate, string? pattern, string? color, bool sex,
            string species)
        {
            Guid = Guid.NewGuid();
            Species = species ?? throw new ArgumentNullException(nameof(species));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            BirthDate = DateTime.Parse(birthDate);
            Pattern = pattern;
            Color = color;
            Sex = sex;
        }

        public Cat(string name, string birthDate, bool sex, string? pattern = null, string? color = null) : this(name, birthDate, pattern, color, sex, "domestic") { }
    }