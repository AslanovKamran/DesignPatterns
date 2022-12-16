using Template_Method.Models;

namespace Template_Method.Readers
{
    internal abstract class DataReader
    {
        abstract public IEnumerable<Product> ReadProductsFromFile(string fileName);

        public virtual decimal GetProductsTotalPrice(string fileName)
        {
            var products = ReadProductsFromFile(fileName);
            return products.Sum(p => p.Price);
        }
    }
}
