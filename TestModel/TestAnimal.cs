using Model;

namespace TestModel
{
    public class TestAnimal
    {
        [Fact]
        public void TestName()
        {
            Animal a = new Animal();
            a.Name = "toto";
            Assert.Equal("toto", a.Name);
        }

        [Fact]
        public void TestBadName()
        {
            var a = new Animal();
            Assert.Throws<BadNameException>(() => a.Name = "  ");
        }

        [Fact]
        public void TestGender()
        {
            var a = new Animal();
            a.Gender = Gender.FEMALE;
            Assert.Equal(Gender.FEMALE, a.Gender);
            a.Gender = Gender.MALE;
            Assert.Equal(Gender.MALE, a.Gender);
        }

        [Fact]
        public void TestSpecies()
        {
            var a = new Animal();
            Assert.NotNull(a.Species);
            Species s = new Species("shlorg");
            a.Species = s;
            Assert.Equal(s, a.Species);
        }
    }
}