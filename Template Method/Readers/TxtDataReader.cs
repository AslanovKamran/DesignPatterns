using Template_Method.Models;

namespace Template_Method.Readers
{
    internal class TxtDataReader : DataReader
    {
        public override IEnumerable<Product> ReadProductsFromFile(string fileName)
        {
            var products = new List<Product>();
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                var items = line.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                products.Add(new Product
                {
                    Title = items[0],
                    Price = decimal.Parse(items[1])
                });
            }
            return products;
        }
    }
}
