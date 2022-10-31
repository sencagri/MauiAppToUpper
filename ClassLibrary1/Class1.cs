using System.Globalization;

namespace ClassLibrary1
{
    public static class Tr
    {
        static CultureInfo trCultureInfo = new CultureInfo("tr");
        public static string Büyüt(this string s)
        {
            return s.ToUpper(trCultureInfo);
        }
    }
}