//using ConsoleCodeAlongGr10;

namespace ConsoleCodeAlongGr10.Tests
{
 
    public class UnitTest1
    {
        MethodsToTest methods = new MethodsToTest();

        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, methods.Add(2, 2));
        }
    }
}