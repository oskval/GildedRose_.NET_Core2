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

            GildedRose expected = new GildedRose(actualItems);
            Switch result = new Switch(expectedItems);

            //Act
            expected.UpdateQuality();
            result.UpdateQuality();

            //Assert
            Assert.Equal(expectedItems[0].SellIn, actualItems[0].SellIn);

            
        }
    }
}