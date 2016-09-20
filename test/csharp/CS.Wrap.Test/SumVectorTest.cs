using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CS.Wrap.Test
{

    public class SumVectorTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(5 + 6 + 9 + 10, TestSum(new int[] { 5, 6, 9, 10 }));
        }

        public int TestSum(int[] intArray )
        {
            IntVector vec = new IntVector(intArray);
            SumVector sum = new SumVector();
            return sum.sum(vec);
        }
    }
}
