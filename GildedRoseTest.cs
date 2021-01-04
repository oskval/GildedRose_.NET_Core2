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

            //Act
            // expected.UpdateQuality();
            // result.UpdateQuality();

            //Assert

            // Assert.Equal(expectedItems[0].SellIn, actualItems[0].SellIn);

            //Assert all
            for(int i = 0; i < 31; i++)
            {
                for(int j = 0; j < actualItems.Count; j++)
                {
                    Assert.Equal(expectedItems[j].SellIn, actualItems[j].SellIn);
                    Assert.Equal(expectedItems[j].Quality, actualItems[j].Quality);
                }
                expected.UpdateQuality();
                result.UpdateQuality();

            }
            
            
        }
    }
}