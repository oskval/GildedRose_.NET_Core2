using System.IO.Compression;
using System.Collections.Generic;

namespace csharpcore
{
    public class Switch
    {
        IList<Item> Items;
        public Switch(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(Item a in Items)
            {
                switch(a.Name.ToString())
                {
                    //Quality increases by 1
                    //If sellin is <= 0 then quality +2
                    //Quality max is 50
                    case "Aged Brie":

                        if(a.Quality + 1 <= 50)
                            a.Quality++;
                        
                        if(a.Quality + 1 <= 50 && a.SellIn <= 0)
                            a.Quality++;

                        a.SellIn--;
                        break;
                    
                    //Quality increases by 1
                    //If sellin is <= 10 then quality +2
                    //If sellin is <= 5 then quality +3
                    //Quality max is 50
                    //When sellin is 0 then quality = 0
                    case "Backstage passes to a TAFKAL80ETC concert":

                        if(a.Quality + 1 <= 50 && a.SellIn > 0)
                            a.Quality++;

                        if(a.Quality + 1 <= 50 && a.SellIn > 0 && a.SellIn <= 10)
                            a.Quality++;

                        if(a.Quality + 1 <= 50 && a.SellIn > 0 && a.SellIn <= 5)
                            a.Quality++;
                        
                        if(a.SellIn <= 0)
                            a.Quality = 0;

                        a.SellIn--;
                        break;

                    case "Sulfuras, Hand of Ragnaros":
                        // Do nothing because "legendery item"
                        break;

                    //Quality decreases by 1
                    //If sellin is <= 0 quality decreases by 2
                    //If item is Conjured, sellin decreases by 2
                    default:

                        if(a.Quality - 1 >= 0)
                            a.Quality--;
                        
                        if(a.Quality - 1 >= 0 && a.SellIn <= 0)
                            a.Quality--;

                        a.SellIn--;

                        if(a.Name.StartsWith("Conjured"))
                            a.SellIn--;
                        break;
                }
            }
        }

       
    }
}
