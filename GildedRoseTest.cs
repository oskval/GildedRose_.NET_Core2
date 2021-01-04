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
                Assert.Equal(expectedItems[0].SellIn, actualItems[0].SellIn);
                Assert.Equal(expectedItems[0].Quality, actualItems[0].Quality);

                Assert.Equal(expectedItems[1].SellIn, actualItems[1].SellIn);
                Assert.Equal(expectedItems[1].Quality, actualItems[1].Quality);

                expected.UpdateQuality();
                result.UpdateQuality();

            }
            
            
        }
    }
}