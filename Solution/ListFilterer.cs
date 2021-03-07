using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //verbose
            //var result = new List<int>();
            //foreach (var item in listOfItems)
            //{
            //    if (item is int)
            //    {
            //        result.Add((int)item);
            //    }
            //}
            //return result;

            //Linq
            return listOfItems.OfType<int>().ToList();
        }


    }

}
