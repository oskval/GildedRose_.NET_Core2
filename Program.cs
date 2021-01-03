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

            // var app = new GildedRose(Items);
            
            var app = new Switch(Items);

            Stopwatch stopwatch = new Stopwatch();
            TimeSpan ts;

            stopwatch.Start();
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
            stopwatch.Stop();
            ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.WriteLine("RunTime " + elapsedTime);

            var test = new GildedRoseTest();
            test.foo();

           

        }
    }
}
