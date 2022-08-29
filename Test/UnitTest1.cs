using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {
            bool x = true;
            Assert.True(x);
        }
    }
}