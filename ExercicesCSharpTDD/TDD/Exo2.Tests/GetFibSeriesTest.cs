using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Xunit;
using Exo2.Bibliotheque;

namespace Exo2.Tests
{
    public class GetFibSeriesTest
    {
        [Fact]
        public void GetFibSeries_With_Range_1_Result_Is_Not_Empty_And_Contains_Zero()
        {
            Fib fib = new Fib(1);

            List<int> result = fib.GetFibSeries();

            Assert.NotEmpty(result);
            Assert.Collection(result, item => Assert.Equal(0, item));
        }

        [Fact]
        public void GetFibSeries_With_Range_6_Contains_3_6_Elements_No_4_Ascending_Order()
        {
            Fib fib = new Fib(6);

            List<int> result = fib.GetFibSeries();

            Assert.Contains(3, result);
            Assert.Equal(6, result.Count);
            Assert.DoesNotContain(4, result);
            Assert.Collection(result,
                item => Assert.Equal(0, item),
                item => Assert.Equal(1, item),
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(5, item)
            );
        }
    }
}