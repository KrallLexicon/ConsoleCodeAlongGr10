//using ConsoleCodeAlongGr10;

namespace ConsoleCodeAlongGr10.Tests
{
 
    public class UnitTest1
    {
        MethodsToTest methods = new MethodsToTest();
        int value = 10;

        public void AddValue()
        {
            value++;
        }

        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, methods.Add(2, 2));
        }

        [Fact]
        public void DeductValueTest()
        {
            Assert.Equal(9, value - 1);
        }

        [Fact]
        public void AddValueTest()
        {
            AddValue();
            Assert.Equal(11, value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void TheoryTest(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}