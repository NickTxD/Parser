using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AngleSharp.Parser.Html;
using ClassLibrary1.Contracts;
using Parser;

namespace ClassLibrary1.Implementations
{
    class LiquidBLL : ILiquidBLL
    {
        public static int StrToInt(string str)
        {
            var regex = new Regex(@"^\s*(?<n>\d+)\s+", RegexOptions.Compiled);
            var result = int.Parse(regex.Match(str).Value);
            return result;
        }
        public ICollection<Liquid> Parse()
        {
            ICollection<Liquid> liqs = new List<Liquid>();
            //УБРАТЬ
            var products = new List<Liquid>();
            try
            {
                //Прописываем user-agent. Без него выкидывает 403
                var client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                //Открываем страницу
                var entrypage = client.OpenRead("http://папироска.рф/category/zhidkosti-dlya-elektronnykh-sigaret/");
                //Парсим
                var parsedentrypage = new HtmlParser().Parse(entrypage);

                //Собираем все объекты класса product
                var productsonpage = parsedentrypage.QuerySelectorAll(".product");

                foreach (var variable in productsonpage)
                {
                    var price = StrToInt(variable.QuerySelector(".price").InnerHtml);

                    var selector = variable.QuerySelector(".pr-title");

                    var link = selector.QuerySelector("a").GetAttribute("href");

                    var name = selector.QuerySelector("a").GetAttribute("title");

                    var subpage = client.OpenRead("http://папироска.рф" + link);
                    var parsedsubpage = new HtmlParser().Parse(subpage);

                    var sel = parsedsubpage.QuerySelector(".option");

                    products.Add(new Liquid(price, name, link, null));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return liqs;
        }
    }
}
