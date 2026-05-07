using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class TestAnimals
    {
        [Fact]
        public void TestAdd()
        {
            Animal test = new Animal() { Gender = Gender.NEUTRAL, Name = "Toto", Species = new Species("truc") };
            Animals animals = new Animals();
            animals.AddAnimal(test);
            Assert.Contains(test, animals.List());
        }

        [Fact]
        public void TestRemove() 
        {
            Animal test = new Animal() { Gender = Gender.NEUTRAL, Name = "Toto", Species = new Species("truc") };
            Animals animals = new Animals();            
            animals.AddAnimal(test);
            animals.AddAnimal(new Animal() { Gender = Gender.MALE, Name = "machin" });
            animals.RemoveAnimal(test);
            Assert.DoesNotContain(test, animals.List());
            Assert.Single(animals.List());
        }
    }
}
