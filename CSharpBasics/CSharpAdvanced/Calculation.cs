using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvanced
{
    public static class Calculation
    {
        public static decimal TotalPrice<T>(T flowers, int count) where T : Flower
        {
            decimal titalPrise = count * flowers.PricePerItem;
            return titalPrise;
        }

        public static string GetCheck<T>(T flowers, int count) where T : Flower
        {
            return new StringBuilder()
                .Append(flowers.ToString())
                .Append($"\nTotal count: {count}")
                .Append($"\nTotal price: {TotalPrice(flowers, count)}")
                .ToString();
        }
    }
}
