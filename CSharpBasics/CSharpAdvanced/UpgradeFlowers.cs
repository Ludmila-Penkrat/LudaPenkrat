using System;
using System.Collections.Generic;

namespace CSharpAdvanced
{
    public static class UpgradeFlowers <T> where T : Flower
    {
        private const int PERSANTAGE = 15; 
        private const int ROUND_NUMBER = 2;

        public static decimal RecalculateFlowerPricePerItem(T flowers)
        {
            decimal newPricePerItem = flowers.PricePerItem + (flowers.PricePerItem * PERSANTAGE / 100);
            return decimal.Round(newPricePerItem, ROUND_NUMBER, MidpointRounding.AwayFromZero);
        }

        public static T RepaintFlower(T flowers)
        {
            Console.Write($"\nEnter color for repaining for {flowers.GetType().Name}:");
            string color = Console.ReadLine();
            if (color.Length == 0)
            {
                flowers.Color = flowers.Color;
                flowers.PricePerItem = flowers.PricePerItem;
            } 
            else if (!color.Equals(flowers.Color))
            {
                flowers.Color = color;
                flowers.PricePerItem = RecalculateFlowerPricePerItem(flowers);
            }
            return flowers;
        }
    }
}
