namespace Template_Method.Models
{
    internal class Product
    {
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; } = default;

        public Product() { }
        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }

        public override string ToString() => $"{Title} {Price}";


    }
}
