namespace ParsingArray.Extensions
{
    public class Item
    {
        public int Index { get; set; }
        public decimal Value { get; set; }
        public string Text { get; set; }
        public bool IsMax { get; set; }
        public override string ToString() => $"{Text}{Index},{Value}";
    }
}