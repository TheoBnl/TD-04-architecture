using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Exception thrown when name is not correct
    /// </summary>
    public class BadNameException : Exception
    {
        public override string Message => "Name can not be empty";
    }

    /// <summary>
    /// possible gender for an animal
    /// </summary>
    public enum Gender { NEUTRAL, FEMALE, MALE};

       
    /// <summary>
    /// An animal
    /// </summary>
    public class Animal
    {
        private string name;
        private Gender gender;
        private Species species;

        public Animal()
        {
            gender = Gender.NEUTRAL;
            species = Species.List.First();
            name = "?";
        }

        /// <summary>
        /// Gets or sets the animal's name
        /// </summary>
        /// <exception cref="BadNameException">If name is empty</exception>
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new BadNameException();
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the animal's gender
        /// </summary>
        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        /// <summary>
        /// Gets or sets the animal's species
        /// </summary>
        public Species Species
        {
            get => species;
            set => species = value;
        }
    }
}
