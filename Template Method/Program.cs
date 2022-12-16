using Template_Method.Readers;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataReader reader = new TxtDataReader();
            var total = reader.GetProductsTotalPrice("someTxtFile.txt");
            Console.WriteLine(total);
        }
    }
}