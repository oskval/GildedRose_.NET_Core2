using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
           
            //Arrange
            ItemsInit initItems = new ItemsInit();
            IList<Item> actualItems = initItems.Init();
            IList<Item> expectedItems = initItems.Init();

            GildedRose expected = new GildedRose(expectedItems);
            Switch result = new Switch(actualItems);

            //Assert all
            //Compare Switch answers with default
            //Note that Conjured Items don't work by default
            //So the Cojured items have been removed from assertion
            for(int i = 0; i < 31; i++)
            {
                for(int j = 0; j < actualItems.Count; j++)
                {
                    if(!expectedItems[j].Name.ToString().StartsWith("Conjured"))
                    {
                        Assert.Equal(expectedItems[j].SellIn, actualItems[j].SellIn);
                        Assert.Equal(expectedItems[j].Quality, actualItems[j].Quality);
                    }
                }
                //Act
                expected.UpdateQuality();
                result.UpdateQuality();

            }
            
            
        }
    }
}