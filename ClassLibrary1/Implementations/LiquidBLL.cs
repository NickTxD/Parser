using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AngleSharp.Parser.Html;
using Parser.Contracts;
using Parser;

namespace Parser.Implementations
{
    class LiquidBLL : ILiquidBLL
    {
        public int StrToInt(string str)
        {
            var regex = new Regex(@"\d+", RegexOptions.Compiled);
            return int.Parse(regex.Match(str).Value);
        }
        public double StrToDouble(string str)
        {
            var regex = new Regex(@"\d*\,?\d+", RegexOptions.Compiled);
            return Convert.ToDouble(regex.Match(str).Value);
        }
        public ICollection<Liquid> Parser()
        {
            //Прописываем user-agent. Без него дропает 403
            var client = new WebClient();
            client.Headers.Add("user-agent",
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //Открываем страницу
            var streamforparse =
                client.OpenRead("http://xn--80aaxitdbjk.xn--p1ai/category/zhidkosti-dlya-elektronnykh-sigaret/");
            //Парсим
            var entrypage = new HtmlParser().Parse(streamforparse);

            var liqs = new List<Liquid>();

            //Получаем общее кол-во страниц с товаром
            var pagecount = 
                StrToInt(
                    entrypage.QuerySelector(".pagination").GetElementsByTagName("li")[3].QuerySelector("a")
                    .InnerHtml);

                for (var i = 26; i < pagecount + 1; i++)
                {
                    client.Headers.Set("user-agent",
                        "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    streamforparse =
                        client.OpenRead(
                            "http://xn--80aaxitdbjk.xn--p1ai/category/zhidkosti-dlya-elektronnykh-sigaret/?page=" + i);
                    entrypage = new HtmlParser().Parse(streamforparse);
                    //Собираем все объекты класса product
                    var productsonpage = entrypage.QuerySelectorAll(".product");
                    //Парсим продукты на одной странице
                    foreach (var variable in productsonpage)
                    {
                        string name, link;
                        int article, price;
                        bool availability, strengthindicated, amountindicated;
                        var strength = new List<double>();
                        var amount = new List<int>();
                        
                        //Парсинг основной странице
                        article = StrToInt(variable.QuerySelector(".article").InnerHtml);
                        var priceraw = variable.QuerySelector(".price");
                        if (priceraw != null)
                        {
                            availability = true;
                            price = StrToInt(priceraw.InnerHtml);
                        }
                        else
                        {
                            price = 0;
                            availability = false;
                        }
                        var selector = variable.QuerySelector(".pr-title");
                        link = "http://xn--80aaxitdbjk.xn--p1ai" + selector.QuerySelector("a").GetAttribute("href");
                        name = selector.QuerySelector("a").GetAttribute("title");
                        //Парсинг сабстраницы
                        client.Headers.Set("user-agent",
                            "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                        var subpage = client.OpenRead(link);
                        var parsedsubpage = new HtmlParser().Parse(subpage);

                        //Парсим доступные значения крепости
                        var strengthtexist = parsedsubpage.GetElementsByName("features[5]");

                        if (strengthtexist.Length == 0)
                            strengthindicated = false;
                        else
                        {
                            var setofstrengtht =
                                parsedsubpage.GetElementsByName("features[5]")[0].QuerySelectorAll("option");
                            strengthindicated = true;
                            strength.AddRange(setofstrengtht.Select(var1 => StrToDouble(var1.InnerHtml)));
                        }

                        //Парсим доступные значения объема
                        var amountexist = parsedsubpage.GetElementsByName("features[3]");

                        if (amountexist.Length == 0)
                            amountindicated = false;
                        else
                        {
                            var setofamount =
                                parsedsubpage.GetElementsByName("features[3]")[0].QuerySelectorAll("option");
                            amountindicated = true;
                            amount.AddRange(setofamount.Select(var1 => StrToInt(var1.InnerHtml)));
                        }
                        //Закрываем поток сабстраницы
                        subpage?.Close();

                        liqs.Add(new Liquid(article, amountindicated, strengthindicated, link, name, availability, price, strength, amount));
                    }
                }

            return liqs;
        }
    }
}
