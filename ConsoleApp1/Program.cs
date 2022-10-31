using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            CultureInfo tr = new CultureInfo("tr-TR", false);
            string test = "i";
            var test2 = test.ToUpper(tr);
            var testResult = test2 == "İ";

            Console.ReadLine();
        }
    }
}