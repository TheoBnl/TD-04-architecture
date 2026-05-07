using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// A species
    /// </summary>
    public class Species
    {
        private string name;
        /// <summary>
        /// Gets the name of species
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// Create a species
        /// </summary>
        /// <param name="name">the name</param>
        public Species(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Species species &&
                   name == species.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }

        /// <summary>
        /// Gets the list of all species
        /// </summary>
        public static Species[] List
        {
            get
            {
                return new Species[]
                {
                    new Species("unknown"),
                    new Species("bird"),
                    new Species("cat"),
                    new Species("dog"),
                    new Species("fish"),
                    new Species("mouse")
                };
            }
        }
    }


}
