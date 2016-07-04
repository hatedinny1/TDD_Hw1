using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Hw1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TDD_Hw1.Tests
{
    [TestClass()]
    public class GetSetSumTests
    {
        [TestMethod()]
        public void SetNum_Is_3_SumCost_Is_6_15_24_21()
        {
            //arrange
            var target = new GetSetSum();
            //act
            var actual = target.GetOrderSetSum(3, x => x.Cost);
            //assert
            var excepted = new List<int> { 6, 15, 24, 21 };
            actual.Should().Equal(excepted);
        }

        [TestMethod]
        public void SetNum_Is_4_SumRevenue_Is_50_66_60()
        {
            //arrange
            var target = new GetSetSum();
            //actual
            var actual = target.GetOrderSetSum(4, x => x.Revenue);
            //assert
            var excepted = new List<int> { 50, 66, 60 };
            actual.Should().Equal(excepted);
        }
    }
}