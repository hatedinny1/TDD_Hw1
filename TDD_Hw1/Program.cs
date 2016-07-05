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

    public class CalGroupTotal
    {

        public IEnumerable<int> GetOrderSetSum(int groupSize,IEnumerable<Order> order,Func<Order,int> orderType)
        {
            var count = 0;
            while (count <= order.Count())
            {
                yield return order.Skip(count).Take(groupSize).Sum(orderType);
                count += groupSize;
            }
        }
    }
}
