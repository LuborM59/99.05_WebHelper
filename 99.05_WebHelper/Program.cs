using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_WebHelper
{
    class Program
    {
        class WebHelper
        {
            //string Header;
            //string Link;

            public string GetHeader(string HeaderText)
            {
                return $"<h1>{HeaderText}</h1>";
            }

            public string GetLink(string Url, string Name)
            {
                return $"<a href=\"{Url}\">{Name}</a>";
            }
        }

        static class WebHelperStatic
        {
            //string Header;
            //string Link;

            public static string GetHeader(string HeaderText)
            {
                return $"<h1>{HeaderText}</h1>";
            }

            public static string GetLink(string Url, string Name)
            {
                return $"<a href=\"{Url}\">{Name}</a>";
            }
        }

        static void Main(string[] args)
        {
            WebHelper wh = new WebHelper();

            Console.WriteLine(wh.GetHeader("Pocitacova skola Gopas"));
            Console.WriteLine(wh.GetLink("http://www.gopas.cz", "Gopas"));
            Console.WriteLine();

            Console.WriteLine(WebHelperStatic.GetHeader("Pocitacova skola Gopas"));
            Console.WriteLine(WebHelperStatic.GetLink("http://www.gopas.cz", "Gopas"));
            Console.WriteLine();
        }
    }
}
