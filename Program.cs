using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace csharpcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            ItemsInit initItems = new ItemsInit();
            IList<Item> Items = initItems.Init();
            
            //Unit tests
            var test = new GildedRoseTest();
            test.foo();
            
            // Printing Switch results
            // Change "Switch" to GildedRose
            // To get the default results
            var app = new Switch(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
           
        }
    }
}
