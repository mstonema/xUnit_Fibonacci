using System;
using System.Linq;
using Xunit;

namespace xUnit_Fibonacci
{
    public class UnitTest1
    {
        public static int myFunction(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else return myFunction(n-1) + myFunction(n-2);
            
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void TestMethod1(int expected, int n)
        {
            int result = myFunction(n);
            Assert.Equal(expected, result);
        }
    }
}
