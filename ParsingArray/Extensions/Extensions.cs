using System;
using System.Collections.Generic;
using System.Linq;

namespace ParsingArray.Extensions
{
    public static class Extensions
    {

        public static decimal[] ToDecimalArray(this string[] sender)
        {

            var decimalArray = Array.ConvertAll(sender, (input) =>
            {
                decimal.TryParse(input, out var decimalValue);
                return decimalValue;
            });

            return decimalArray;

        }

        public static List<Item> ItemsFromArray(this decimal[] sender) => 
            sender.Select((value, Index) => new Item() {Index = Index, Value = value}).ToList();
        
        public static bool AllDecimals(this string[] sender) => 
            sender.All(item => decimal.TryParse(item, out var test));
        
        public static Item MaxItem(this List<Item> sender) => 
            sender.OrderByDescending(x => x.Value).FirstOrDefault();
    }
}
