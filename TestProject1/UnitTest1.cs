using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add()
        {
            var calc = new Class1();
            Assert.Equal(5, calc.Add(1, 3));
        }
    }
}