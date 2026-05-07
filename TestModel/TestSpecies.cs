using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class TestSpecies
    {
        [Fact]
        public void TestName()
        {
            var s = new Species("truc");
            Assert.Equal("truc", s.Name);
        }

        [Fact]
        public void TestList()
        {
            var list = Species.List;
            Assert.NotEmpty(list);
        }
    }
}
