using System;
using System.IO;

namespace OpenHtmlToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = File.ReadAllText("leping.html");

            var pdf = OpenHtmlToPdf.Pdf
                .From(html)
                .Content();

            File.WriteAllBytes("output.pdf", pdf);
        }
    }
}

