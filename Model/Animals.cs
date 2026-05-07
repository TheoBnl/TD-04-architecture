using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Exception thrown when the name already exists
    /// </summary>
    public class NameAlreadyExists:Exception
    {
        public override string Message => "This name already exists";
    }

    /// <summary>
    /// COmpose all animals
    /// </summary>
    public class Animals
    {
        private List<Animal> animals;

        public Animals()
        {
            animals = new List<Animal>();
        }

        /// <summary>
        /// Add an animal
        /// </summary>
        /// <param name="a">the animal to add</param>
        /// <exception cref="NameAlreadyExists">if another animal with same name exists</exception>
        public void AddAnimal(Animal a)
        {
            if (animals.Find((animal) => { return animal.Name == a.Name; })!=null)
                throw new NameAlreadyExists();
            animals.Add(a);
        }

        /// <summary>
        /// Remove the animal
        /// </summary>
        /// <param name="a">the animal to remove</param>
        public void RemoveAnimal(Animal a)
        {
            animals.Remove(a);
        }
        
        /// <summary>
        /// Gets all the animals
        /// </summary>
        /// <returns>an array containing all animals</returns>
        public Animal[] List()
        { return animals.ToArray(); }
    }
}
