namespace csharpcore
{
    public class Item
    {
        public Item(){}
        public Item(string name, int sellin, int quality)
        {
            Name = name;
            SellIn = sellin;
            Quality = quality;
        }
        
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}
