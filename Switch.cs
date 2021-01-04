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
                    case "Aged Brie":
                           
                        break;
                    
                    case "Backstage passes to a TAFKAL80ETC concert":

                        break;

                    case "Sulfuras, Hand of Ragnaros":

                        break;

                    case "Conjured Mana Cake":

                        break;

                    default:

                        if(a.Quality - 1 >= 0)
                            a.Quality--;
                        
                        if(a.Quality - 1 >= 0 && a.SellIn <= 0)
                            a.Quality--;

                        a.SellIn--;

                        break;
                }
            }
        }

       
    }
}
