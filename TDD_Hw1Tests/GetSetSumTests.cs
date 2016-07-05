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
        public void GroupSize_Is_3_CalGroupCost_Should_Be_6_15_24_21()
        {
            //arrange
            var target = new CalGroupTotal();
            var groupSize = 3;
            var order = GetOrderList();
            //act
            var actual = target.GetOrderSetSum(groupSize,order, x => x.Cost);
            //assert
            var excepted = new List<int> { 6, 15, 24, 21 };
            actual.Should().Equal(excepted);
        }

        [TestMethod]
        public void GroupSize_Is_4_SumRevenue_Should_Be_50_66_60()
        {
            //arrange
            var target = new CalGroupTotal();
            var groupSize = 4;
            var order = GetOrderList();
            //actual
            var actual = target.GetOrderSetSum(groupSize,order, x => x.Revenue);
            //assert
            var excepted = new List<int> { 50, 66, 60 };
            actual.Should().Equal(excepted);
        }

        public IEnumerable<Order> GetOrderList()
        {
            var order = new List<Order>();
            order.Add(new Order { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            order.Add(new Order { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            order.Add(new Order { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            order.Add(new Order { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            order.Add(new Order { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            order.Add(new Order { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            order.Add(new Order { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            order.Add(new Order { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            order.Add(new Order { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            order.Add(new Order { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            order.Add(new Order { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
            return order;
        }
    }
}