using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Hw1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class GetSetSum
    {

        public IEnumerable<int> GetOrderSetSum(int setNum,Func<Order,int> orderType)
        {
            
            var order = GetOrderList();
            var count = 0;
            while (count <= order.Count())
            {
                yield return order.Skip(count).Take(setNum).Sum(orderType);
                count += setNum;
            }
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
