using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;

namespace Zadacha26
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"input.html";
            
            HtmlDocument doc = new HtmlDocument();
            doc.Load(path);

            var titleNode = doc.DocumentNode.Descendants("title").FirstOrDefault();
            Console.WriteLine("Title: " + titleNode.InnerText);
            var body = doc.DocumentNode.SelectSingleNode("//body");
            Console.WriteLine("Body: \n" + body.InnerText);
        }
    }

}
